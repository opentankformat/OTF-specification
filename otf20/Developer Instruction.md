# DEVELOPER INSTRUCTION

Please find the _Message Implementation Guide_ (MIG) for the proper OTF version in /release folder

## GENERATING OTF FILES FROM CLASSES
Import the C# or DLL file from the release/bin folder into your project.
It has a namespace based on the OTF version which makes it easy to support backward compatibility.
Create classes and serialize them into XML or JSON.

Check the sample C# project in project/2_Solution folder.

Use the sample files in the release/samples folder for testing.

## IMPORT OTF FILES INTO CLASSES
Import the C# or DLL file from the release/bin folder into your project.
It has a namespace based on the OTF version which makes it easy to support backward compatibility.
Deserialize XML or JSON files into associated OTF classes

Check the sample C# project in project/2_Solution folder.

Use the sample files in the release/samples folder for testing.