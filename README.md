# CryptDecrypt
Tool to crypt / decrypt assets for MELHARFI game engine

Hi there, using my game engine to develop my current game, an RPG network, here is 2 links if you want to have a look, but the videos are in French, so I’m sorry :-)

Part 1
https://www.youtube.com/watch?v=D6VQARWxfvs

Part 2
https://www.youtube.com/watch?v=ufQObcknmVY

As any game need to protect its asset, i build a small tool that use Rijndael AES encrypted algorithm

So here is how to use it :

Just launch the program and click "Parcourir ..." , and then look for your asset in hard drive.

Unfortunately the tool handle only a few extensions like : txt, mp3, jpg, png, gif

Trying to crypt other thing will raise an exception, unless you modify the source yourself or notify me.

After that you chose an extension to replace the original one to avoid recognizing type of file, by default it's **.dat**, it's a good way to make the same extension for all your assets, that let the user can't recognize which files is for sound or for graphics, and don't worry, the manager (MELHARFI Game Engine) you can find at :
https://github.com/melharfi/MELHARFI-2D-Game-Engine
Do recognize the type of file because the extension value is crypt and stored inside the file ^^.

If by any reason you afraid that your original file will be corrupted while encrypt it, you can check the "**Copie**" checkbox.

And last step is enter an index of crypt, by default it's 1, in reality, it's not really a hard crypt algorithm, you can modify that if you want, AND you must do the same in the **DecryptFile()** method inside Manager, "**Manager.manager.DecryptFile()**. at MELHARFI-2D-Game-Engine

The index should be between 0 until 255, both value are allowed.

Finally you can push **Crypt** button	

By the way, you can select many files in the same time, or even select a directory, then same parameters will be done for them all.

**Decrypt**

To decrypt the file, just select it in "Parcourir ..." and then click "Decrypt" button
