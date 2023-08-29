#About Open Tank Format (OTF)
Open Tank Format (OTF) is an open file format for data exchange related to the tank container industry. OTF is used by development-teams.

Please check [www.opentankformat.org](http://www.opentankformat.org "www.opentankformat.org") for more information.

#Table of Contents

[TOC]

#License
OTF is owned and copyrighted by Lucrasoft Solutions B.V. (known for their DEPOT Software and SYNDA brands). This commercial dependency ensures that OTF will continuously be updated and expanded according to market demands. 

[OTF is licensed under Attribution-NoDerivatives 4.0 International (CC BY-ND 4.0)](https://creativecommons.org/licenses/by-nd/4.0/ "OTF is licensed under Attribution-NoDerivatives 4.0 International (CC BY-ND 4.0)")


It can be shared and used by anybody, but it is not allowed to publish a modified version of the standard.

# Interface Mapping Instructions
Please find the _Message Implementation Guide_ (MIG) for the proper OTF version in [release/](release/) folder

1. Use the XSD files in the [release/bin/separate (xsd)/](release/bin/separate%20(xsd)) folder for mapping

Use the sample files in the release/samples folder for testing.

# Developer Instructions
Please find the _Message Implementation Guide_ (MIG) for the proper OTF version in [release/](release/) folder

## Backward Compatibility
OTF library has a namespace that contains the version number based on the OTF version (such as OTF20, or OTF21), which makes it easy to support backward compatibility in code.

## How to Serialize OTF Files from Classes
1. Import the C# or DLL file from the [release/bin/](release/bin/) folder into your project
2. Create classes and serialize them into XML or JSON

Check the sample C# project in [project/2_Solution/](project/2_Solution/) folder.

## How to Deserialize OTF Files into Classes
1. Import the C# or DLL file from the [release/bin/](release/bin/) folder into your project
2. Deserialize XML or JSON files into associated OTF classe

Use the sample files in the [release/samples/](release/samples/) folder for testing.
Check the sample C# project in [project/2_Solution](project/2_Solution/) folder.
