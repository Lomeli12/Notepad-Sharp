------What is Sharp-Updater------

Sharp-Updater is a Generic Updater running under .NET environment.

The aim of Sharp-Updater is to provide a ready to use and configurable updater which downloads a update package then installs it, much like GUP.

------Why Sharp-Updater?------

Sharp-Updater was created for the upcoming Notepad# project. I wanted to use GUP, just like Notepad++, but decided “What the hell” and made my own updater in C# based off of GUP.

Just like GUP, Sharp-Updater has be programmed so that anyone can use it with there programs by just editing two files. It has a tiny footprint(though not as tiny as GUP). It’s also licensed under the LGPL.

------How does Sharp-Updater work?------

Sharp-Updater can be launched by your program or manually.
Just like GUP, it reads from a xml configuration file for getting the current version of your program and url where Sharp-Updater gets update information, checks the url (with given current version) to get the update package location, downloads the update package, then run the update package (it MUST be an exe) in question.

However, Sharp-Updater’s process has been shortened to 3 variables client side and only 2 variables server side. Sharp-Updater checks the difference in the xml files itself(Oh yeah, Sharp-Updater uses two xml files unlike GUP using a php and an xml file).

----So what do you need to use it?----

A url to provide the update information to your Sharp-Updater and an another url location to store your update package, that’s it!

----And then?----

All you have to do is point Sharp-Updater to your url update page (by modifying info.xml), then work on your pointed url update page (see Update.xml comes with the release) to make sure it responds to your Sharp-Updater with the correct xml data.

------Notable Differences------

    - Noticeable smaller. Sharp-Updater is only 12KB(Sharp-Updater and Info.XML), while GUP is 390KB(GUP, gup.xml, libcurl.dll)
	- Doesn't use an extra DLL
    - Written in C# as opposed to C++

------Who & whom------

Who will need it?

Being LGPLed, Sharp-Updater can be integrated in both commercial (or close source) and open source project.
So if you run a commercial or open a source project under MS Windows and you release your program at regular intervals, then you may need Sharp-Updater to notice your users the new update.

To whom should you say “thank you”?

Anthony Lomeli

------NOTE------

When you upload and Update.xml, give it a few minutes to update worldwide. Just like anything you upload via FTP, many programs(including Sharp-Updater) won't notice the change for a while.