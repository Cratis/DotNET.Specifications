#! /bin/bash
rm -rf artefacts
mkdir artefacts
mkdir artefacts/lib
mkdir artefacts/lib/netcoreapp1.1
cd ./Source
dotnet build
cd ..
cp ./Source/bin/Debug/netcoreapp1.1/*.dll ./artefacts/lib/netcoreapp1.1
cp ./Source/bin/Debug/netcoreapp1.1/*.pdb ./artefacts/lib/netcoreapp1.1
cp ./Source/Package.nuspec ./artefacts
cd artefacts
nuget pack Package.nuspec -symbols -version 1.0.0 -suffix nightly003 

#dotnet pack ./Source -c Release -o artefacts --version-suffix nightly001