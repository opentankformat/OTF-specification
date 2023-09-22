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
