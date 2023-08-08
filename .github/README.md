# UnityReferenceReminder
For Unity3D in C# written simple null object reference finder. 

## About
* This property drawer helps you to manage your null reference type objects. Especially helpful for fast reference assign from inspector.
* Useful for ```Game jams.```

https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/c808866c-1763-4aec-b5cf-0881b55debec

## Installation
At the installation part, you can download this package using Unity's Package Manager.

* Firstly, click the `Code` button of this repository
  
![Screenshot 2023-08-08 194641](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/e100bf73-fe89-407c-aab4-ac662b26bb8e)

* After that, copy the path of this package.

![Screenshot 2023-08-08 194735](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/de2e6259-8e33-4bd5-8245-e224cc4aadd7)

* Then, go to `Unity Editor/Window/Package Manager` path from your editor.

![Screenshot 2023-08-08 194842](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/d3314aa1-433b-414d-acd3-e25161436c81)

* At the package manager, click the `+` icon then select the `Add package from git URL...` section.
  
![Screenshot 2023-08-08 194954](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/fc4fd716-7c43-4f6b-b126-717d1d6d506d)

* After selecting that option, now you can paste the git path to here and press the `Add` button.

![Screenshot 2023-08-08 195040](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/8a39a60e-df4b-4509-b156-6276f5a5e428)

* Finally, you have successfully added this package to your project!
  
![Screenshot 2023-08-08 195147](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/208f061e-f677-41ad-9f8e-11f9f1822155)

## Usage
* For using it just add ```[RefReminder]``` attribute to your reference type fields.

Example:

```csharp
using UnityEngine;

public class ReminderTest : MonoBehaviour
{
    [RefReminder("Scene assign")] public GameObject reminderTest;
    [RefReminder("Doesn't matter whether assigned or not!")] public GameObject reminderTest1;
    [RefReminder] public GameObject reminderTest2;
    
    public string mString;
    public float mFloat;
    public int mInt;
}
```

You can also add comments to leave a message to yourself:
```csharp
[RefReminder("Message 1")]
[RefReminder("Message 2")]
```

![Screenshot 2023-08-08 200209](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/94aa5d55-3b95-41cd-9220-8f5294d77f77)

## License
This code is released under MIT license. Modify, distribute, sell, fork, and use this as much as you like. Both for personal and commercial use. I hold no responsibility if anything goes wrong.
If you use this, you don't need to refer to this repo, or give me any kind of credit but it would be appreciated. At least a ⭐ would be nice.

## Contributing
Pull Requests are welcome. 
But, note that by creating a pull request you are giving me permission to merge your 
code and release it under the MIT license mentioned above.

## Need Support?
In case of any issue you can submit an issue for this repository. Also don't forget to use tickets for your issue. 
So that way I can notice the issue easier.

## Support Me
You can support me from github sponsors or <a href="https://www.buymeacoffee.com/mertbalkan">buy me a coffee ☕</a>
