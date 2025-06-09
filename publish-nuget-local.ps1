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

Write-Host "Searching for 'Release' directories under: $SearchRoot"
$ReleaseDirectories = Get-ChildItem -Path $SearchRoot -Directory -Recurse -Filter "Release" -ErrorAction SilentlyContinue

if ($ReleaseDirectories.Count -eq 0) {
    Write-Host "No 'Release' directories found under $SearchRoot."
    Write-Host "Script finished. No files were copied."
    exit 0
}

Write-Host "Found $($ReleaseDirectories.Count) 'Release' director(y/ies). Searching for .nupkg files within them..."

$copiedFilesCount = 0
$filesToCopy = New-Object System.Collections.Generic.List[System.IO.FileInfo]

foreach ($dir in $ReleaseDirectories) {
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
                $filesToCopy.Add($file)
            } else {
                Write-Host "    -> Does not match filter, will be skipped."
            }
        }
    }
}

if ($filesToCopy.Count -eq 0) {
    Write-Host "No .nupkg files matching the project filter found in any of the 'Release' directories."
    Write-Host "Script finished. No files were copied."
    exit 0
}

Write-Host "--------------------------------------------------"
Write-Host "Found a total of $($filesToCopy.Count) .nupkg file(s) matching the filter to process."
Write-Host "--------------------------------------------------"

foreach ($nupkgFile in $filesToCopy) {
    $DestinationPath = Join-Path -Path $LocalNuGetFeed -ChildPath $nupkgFile.Name
    Write-Host "Attempting to copy '$($nupkgFile.FullName)'"
    Write-Host "                 to '$DestinationPath'..."
    try {
        Copy-Item -Path $nupkgFile.FullName -Destination $DestinationPath -Force -ErrorAction Stop
        Write-Host "Successfully copied '$($nupkgFile.Name)'."
        $copiedFilesCount++
    }
    catch {
        Write-Error "Failed to copy '$($nupkgFile.FullName)'. Error: $($_.Exception.Message)"
    }
    Write-Host ""
}

Write-Host "--------------------------------------------------"
if ($copiedFilesCount -gt 0) {
    Write-Host "Successfully copied $copiedFilesCount .nupkg file(s) to $LocalNuGetFeed."
} else {
    Write-Host "No .nupkg files were successfully copied."
}
Write-Host "Script finished."