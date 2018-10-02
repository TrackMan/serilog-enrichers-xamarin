# Serilog Enrichers for Xamarin
[![Build status](https://osteost.visualstudio.com/serilog-enrichers-xamarin/_apis/build/status/serilog-enrichers-xamarin-CI)](https://osteost.visualstudio.com/serilog-enrichers-xamarin/_build/latest?definitionId=5)
[![NuGet](https://img.shields.io/nuget/v/Serilog.Enrichers.Xamarin.svg)](https://www.nuget.org/packages/Serilog.Enrichers.Xamarin)

Xamarin Android and iOS Device information enrichment for Serilog

## Installing

> Install-Package Serilog.Enrichers.Xamarin

## Usage

```csharp
var configuration = new LoggerConfiguration()
    // Android
    .Enrich.WithDisplayMetrics()     // Adds `DisplayMetrics` property
    .Enrich.WithFirmwareVersion()    // Adds `FirmwareVersion` property
    .Enrich.WithHardwareVersion()    // Adds `HardwareVersion` property
    .Enrich.WithDeviceId()           // Adds `DeviceId` property
    .Enrich.WithDeviceName()         // Adds `DeviceName` property
    .Enrich.WithManufacturerName()   // Adds `DeviceManufacturer` property
    .Enrich.WithDeviceOrientation()  // Adds `DeviceOrientation` property (can be expensive since it is not cached)
    .Enrich.WithPackageName()        // Adds `PackageName` property
    .Enrich.WithPackageVersionName() // Adds `PackageVersionName` property
    .Enrich.WithPackageVersionCode() // Adds `PackageVersionCode` property
    
    // iOS
    .Enrich.WithDisplayMetrics()     // Adds `DisplayMetrics` property
    .Enrich.WithSystemVersion()      // Adds `DeviceSystemVersion` property
    .Enrich.WithDeviceModel()        // Adds `DisplayModel` property
    .Enrich.WithDeviceId()           // Adds `DisplayId` property
    .Enrich.WithDeviceName()         // Adds `DisplayName` property
    .Enrich.WithPackageName()        // Adds `PackageName` property
    .Enrich.WithPackageVersionName() // Adds `PackageVersionName` property
    .Enrich.WithPackageVersionCode() // Adds `PackageVersionCode` property
```

# License
This project is licensed under the MIT License, see the LICENSE file for more information
