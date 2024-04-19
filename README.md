# CLI PrintTool for Rood Fluweel Delphi

This is a CLI version of the Rood Fluweel PrintTool.
It will print tickets to PDF files, instead of an actual printer.

This version of the tool is using `.NET 8.0` and a recent version of DevExpress, which allows it to be truly cross-platform.


## Dependencies
Most dependencies are handled through NuGet packages,
with the exception of: 
- `RoodFluweel.Printing.Model.dll`. Ideally this is replaced by the source file, or a NuGet packages
- DevExpress 23.2: Binary assemblies are not included in the repo, as a license is required.

## How to build
* Clone the repo
* `dotnet build`

## How to run
* `dotnet run`
