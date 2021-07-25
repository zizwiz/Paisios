# Paisios
RS232 Test App for Data Coms
[Paisios - Patron Saint of Signalmen]
[![Open Source Love](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/)


This apps main task is to allow you to send RS232 signals either as Text or Hex and receive replies. It does not analyse the replies. It will allow the signals to be sent as single signals or in many different permutations.  

How it works.
 
Open the app and you will have access to the following.


RS232 Port Settings

The app will find all the com ports that are available on your device and show them. It refreshes the list periodically so if you close a com port it will not show in the list.

The Baud rate has settings up to 1Mega Baud but note not all devices will be able to handle this speed, you will need to check the driver for your device.

Once set then click “Open Port” and now the GUI will change and will make more items accessible.


Data Arena

There are 6 different Textboxes to use to enter data to send out via RS232. 
On the left is a “Clear” button that will clear the contents of the text box and reset the Delay and Iteration values. To the right of it is the number of the text box that you can use if you are setting up a sequence to send see later in this document how to send sequences.
On the right is a Send button that will send the contents of the text box out via RS232.

•	Delay range 0ms – 999999ms
•	Iterations range 0ms – 99999999ms

Data Mode

Use this to select he type of data (TEXT or HEX) you wish to send and receive. 

Send File

Here you can create a file with a command on each line as seen below

•	1B423F04
•	1B413F04
•	1B54313F04
•	1B4F313F03


You can then add how much delay you want to set between each line being sent, how many time you want each line sent and how many times you want the whole set sent.

Run Sequence

In this box you can write the sequence of numbers of the Text boxes in the “Data Arena” you want to send. When you run the sequence each line will pick up the delay and iterations from its entry in the “Data Arena”. You can send the data in any order and also repeat it in any order e.g.

1
3
4
2
1
3
4
1


Data formatting

There are some extra features at the bottom that may be useful in some circumstances to use.

•	Log – this will log all outgoing and incoming data to a file you specify.
•	Timestamp – this feature adds a time stamp to all sent and received data and if you are using logging it will log this time stamp as well.
•	Show Data - will turn on and off the ability for the App to write its output to the screen. The App is written in C# with .Net and it has been found that when the output box has been running for a while and not been cleared it will slow the App down. Although the App will allow up to 1000 lines and then clear the oldest 500 you may wish not to write anything to the screen. In that case you untick this feature.

Other Buttons

•	Save will save the contents of the output window to a file you assign.
•	Clear will clear the output window.
•	Close will close the App. When it closes it saves many items so when you start again you do not need to reset the configuration.
