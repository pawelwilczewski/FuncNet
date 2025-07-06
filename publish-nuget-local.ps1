$LocalNuGetFeed = "C:\dev\LocalNuGetFeed"
$AllowedProjectNamePrefixes = @("FuncNet", "FuncNet.Analyzers")

$SearchRoot = $PSScriptRoot 
if ($null -eq $PSScriptRoot -or $PSScriptRoot -eq "") {
    $SearchRoot = Get-Location 
    Write-Warning "PSScriptRoot not defined. Using current location as SearchRoot: $SearchRoot"
}

if (-not (Test-Path $LocalNuGetFeed)) {
    Write-Host "Local NuGet feed directory not found. Creating: $LocalNuGetFeed"
    try {
        New-Item -ItemType Directory -Path $LocalNuGetFeed -Force -ErrorAction Stop | Out-Null
        Write-Host "Successfully created directory: $LocalNuGetFeed"
    }
    catch {
        Write-Error "Failed to create directory $LocalNuGetFeed. Error: $($_.Exception.Message)"
        exit 1
    }
}

Write-Host "Searching for 'Release' and 'Debug' directories under: $SearchRoot"
$BuildDirectories = Get-ChildItem -Path $SearchRoot -Directory -Recurse -Filter "Release" -ErrorAction SilentlyContinue
$BuildDirectories += Get-ChildItem -Path $SearchRoot -Directory -Recurse -Filter "Debug" -ErrorAction SilentlyContinue

if ($BuildDirectories.Count -eq 0) {
    Write-Host "No 'Release' or 'Debug' directories found under $SearchRoot."
    Write-Host "Script finished. No files were moved."
    exit 0
}

Write-Host "Found $($BuildDirectories.Count) build director(y/ies). Searching for .nupkg files within them..."

$movedFilesCount = 0
$filesToMove = New-Object System.Collections.Generic.List[System.IO.FileInfo]

foreach ($dir in $BuildDirectories) {
    $nupkgFilesInDir = @(Get-ChildItem -Path $dir.FullName -Filter "*.nupkg" -File -ErrorAction SilentlyContinue)
    if ($nupkgFilesInDir.Count -gt 0) {
        Write-Host "Found $($nupkgFilesInDir.Count) .nupkg file(s) in $($dir.FullName):"
        foreach ($file in $nupkgFilesInDir) {
            Write-Host "  - Checking file: $($file.Name)" 
            $match = $false
            foreach ($prefix in $AllowedProjectNamePrefixes) {
                if ($file.Name.StartsWith($prefix + ".") -and $file.Name.Substring($prefix.Length + 1) -match "^\d") {
                    $match = $true
                    break
                }
            }

            if ($match) {
                Write-Host "    -> Matches filter, will be processed."
                $filesToMove.Add($file)
            } else {
                Write-Host "    -> Does not match filter, will be skipped."
            }
        }
    }
}

if ($filesToMove.Count -eq 0) {
    Write-Host "No .nupkg files matching the project filter found in any of the build directories."
    Write-Host "Script finished. No files were moved."
    exit 0
}

Write-Host "--------------------------------------------------"
Write-Host "Found a total of $($filesToMove.Count) .nupkg file(s) matching the filter to process."
Write-Host "--------------------------------------------------"

foreach ($nupkgFile in $filesToMove) {
    $DestinationPath = Join-Path -Path $LocalNuGetFeed -ChildPath $nupkgFile.Name
    Write-Host "Attempting to move '$($nupkgFile.FullName)'"
    Write-Host "                 to '$DestinationPath'..."
    try {
        Move-Item -Path $nupkgFile.FullName -Destination $DestinationPath -Force -ErrorAction Stop
        Write-Host "Successfully moved '$($nupkgFile.Name)'."
        $movedFilesCount++
    }
    catch {
        Write-Error "Failed to move '$($nupkgFile.FullName)'. Error: $($_.Exception.Message)"
    }
    Write-Host ""
}

Write-Host "--------------------------------------------------"
if ($movedFilesCount -gt 0) {
    Write-Host "Successfully moved $movedFilesCount .nupkg file(s) to $LocalNuGetFeed."
} else {
    Write-Host "No .nupkg files were successfully moved."
}
Write-Host "Script finished."