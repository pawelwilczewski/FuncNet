$LocalNuGetFeed = "C:\dev\LocalNuGetFeed"

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
$filesToMove = New-Object System.Collections.Generic.List[System.IO.FileInfo]

foreach ($dir in $ReleaseDirectories) {
    $nupkgFilesInDir = @(Get-ChildItem -Path $dir.FullName -Filter "*.nupkg" -File -ErrorAction SilentlyContinue)
    if ($nupkgFilesInDir.Count -gt 0) {
        Write-Host "Found $($nupkgFilesInDir.Count) .nupkg file(s) in $($dir.FullName)"
        $filesToMove.AddRange([System.IO.FileInfo[]]$nupkgFilesInDir)
    }
}

if ($filesToMove.Count -eq 0) {
    Write-Host "No .nupkg files found in any of the 'Release' directories."
    Write-Host "Script finished. No files were copied."
    exit 0
}

Write-Host "--------------------------------------------------"
Write-Host "Found a total of $($filesToMove.Count) .nupkg file(s) to process."
Write-Host "--------------------------------------------------"

foreach ($nupkgFile in $filesToMove) {
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