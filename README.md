# CzechIt Android App
<img src="https://telegra.ph/file/9e71f933a950f062ffd17.png">

### First year, summer 2021, Programming 2

**Goal**: create an application for learning **Czech language**.

# Documentation

## Launching 

The app is launched via the [mff.czechit-Signed.apk](https://github.com/dfmode/CzechIt/blob/main/mff.czechit-Signed.apk) file. 
You need to open the **file** on a phone with the **android** operating system and follow the instructions. For development and modifications, I recommend using [Visual Studio 2019](https://visualstudio.microsoft.com/cs/downloads/). It is important to choose **Xamarin** extension when installing

## Modes

The app supports **three** modes: 
1. Insert a letter
2. Insert a word
3. Translate the word

## Program structure
<img src="https://telegra.ph/file/090dcb0ff04b1f29d2868.jpg">

The application is built on the concept of windows. At the start, the user is greeted by the **main menu** and **5 buttons**. Each button leads to a **new page** that opens on top of the **previous one**. Each mode takes data from QuestionsClass and displays the corresponding data to the user.

#### `App.xaml, App.xaml.cs` 
Technical files that launch the application and open MainPage.

#### `MainPage.xaml, MainPage.xaml.cs` 
<img src="https://telegra.ph/file/8d6860236ae6b1108d99a.jpg">
The main page that the user sees at startup. it has 5 buttons that lead to other windows.

#### `TaskOne.xaml, TaskOne.xaml.cs | TaskThree.xaml, TaskThree.xaml.cs | TaskTwo.xaml, TaskTwo.xaml.cs`
<img src="https://telegra.ph/file/92163a7e55cf5440788a5.jpg">
<img src="https://telegra.ph/file/6fce010dc50bc3e8cb3ba.jpg">
<img src="https://telegra.ph/file/33744015d63fc155737e6.jpg">
The main functionality of the application is contained in these files. due to the fact that only the corresponding C# code can edit the xaml file, it became necessary to copy the code and slightly change it for each mode.
When opening any of these windows, a question from `QuestionsClass` is requested and displayed to the user. After that, depending on the user's action, a new question, a warning about an incorrect answer, a reset of points, a skipped question or a correct answer may be displayed.

#### `Stats.xaml, Stats.xaml.cs` 
<img src="https://telegra.ph/file/11c512c7b363c4fbaf309.jpg">

Statistics include 5 indicators that are requested when you get to this page from `QuestionsClass`.

#### `About.xaml, About.xaml.cs` 
<img src="https://telegra.ph/file/be96995d2b3ece8ab9c8f.jpg">

This is a page that can be filled with useful information in other circumstances :)


## About xaml and C Sharp 

There are [two ways](https://stackoverflow.com/questions/37830770/benefits-of-xaml-over-c-sharp-or-vice-versa-in-xamarin-forms) to write an application. Using only C# code or using C# together with xaml. I chose the second option because it is much easier to understand and work with. Visual components are added to xaml and the behavior of the component is prescribed in the corresponding C# document.


## Possible improvements

* Instead of using `QuestionsClass`, it is possible to use an internal sql database.
* Add questions with audio and photo material.
* Some improvements in the design.

## Course of work

To start working on the project, it was necessary to have a good understanding of the concept of classes, as well as to become familiar with the xaml format. To find out, I used several books and youtube.
It was quite difficult to work on the project due to the fact that Xamarin provides high abstraction and the reason for the error is not always clear. There is also quite a little high-quality material on the Internet.

Sources that I used:
  1. [James Montemagno](https://www.youtube.com/user/jamesmontemagno)
  2. [Byte++](https://www.youtube.com/channel/UCG7GW-X1cczyzLswoYTTnjQ)
  3. [Programming with Mosh](https://www.youtube.com/user/programmingwithmosh)
