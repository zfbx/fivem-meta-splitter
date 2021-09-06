# MetaSplit (For FiveM)

[![MIT License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge&logo=opensourceinitiative)](https://opensource.org/licenses/MIT)
[![Donate on PayPal](https://img.shields.io/badge/Donate-PayPal-%2300457C?style=for-the-badge&logo=paypal)](https://paypal.me/zfbx)
[![Sub on Patreon](https://img.shields.io/badge/Support-Patreon-%23FF424D?style=for-the-badge&logo=patreon)](https://www.patreon.com/zfbx)
[![Buy Me a Pizza](https://img.shields.io/badge/Pizza-BuyMeACoffee-%23FFDD00?style=for-the-badge&logo=buymeacoffee)](https://www.buymeacoffee.com/zfbx)

### split vehicles.meta or handling.meta files into seperate files by vehicle name

Do you have a massive handling.meta or vehicles.meta that is unweildy and hard to maintain and compare changes to with git? Well then this is for you! Drag your handling/vehicles.meta onto the MetaSplit.exe and in the same directory as the file you dragged an output folder will be filled with folders named after each vehicle with a handling/vehicles.meta inside specific only to that vehicle. Now you're probably thinking "Well I mean that has some benefits with git compare but how does that help my server??" Well i'm glad you asked stranger! You can actually load multiple handlings in a single resource and I've included an `example` fivem resource that shows you how to do that exactly with an adder and a police car.


## How to use

first get a **vehicles.meta** or **handling.meta** (xml) file (exported .ymt) then you can either do:

**Option 1:** Drag the file onto `MetaSplit.exe` (and output folder will be created in the same directory as the .meta)

*or*

**Option B:** Open a command prompt with `MetaSplit.exe Path/To/File` (Example: `MetaSplit.exe .\example\data\adder\handling.meta`) and the output folder will be generated in the same folder in which you opened the command prompt to