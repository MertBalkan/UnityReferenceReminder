# UnityReferenceReminder
For Unity3D in C# written simple null object reference finder. 

## About
* This property drawer helps you to manage your null reference type objects. Especially helpful for fast reference assign from inspector.
* Useful for ```Game jams.```


https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/3d33c1d1-ce77-494a-b95b-0357a2abb2bf


## Installation
At the installation part, you can download this package using Unity's Package Manager.

* Firstly, click the `Code` button of this repository 

![image](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/692d578a-c9b5-47d5-80f5-680a49a5b919)

* After that, copy the path of this package.

![image](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/914aea2b-8460-49da-85fc-2b6d81e7fdca)

* Then, go to `Unity Editor/Window/Package Manager` path from your editor.

![image](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/ea5a8198-c1dd-4caf-8c77-a000e5f2165a)

* At the package manager, click the `+` icon then select the `Add package from git URL...` section.
  
![image](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/5da060e3-2b9a-4eb5-b005-40124f3795f4)

* After selecting that option, now you can paste the git path to here and press the `Add` button.
  
![image](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/2d26ce48-7fb4-4a97-883e-aa7888e341e3)

* Finally, you have successfully added this package to your project!
  
![image](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/23f424ce-2ea0-46bf-9d8b-655c72aa3617)

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

![image](https://github.com/MertBalkan/UnityReferenceReminder/assets/43827959/90637b1e-1ad9-41e2-92f9-ab8c5ad6d3d5)

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
