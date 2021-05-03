# dotnetNamedMutex
play with mutexes and semaphores

....
set this false or true to try either mutex or semaphores
//set this to false to try the counting semaphore example
const bool runMutex = true;


...
MUTEX:
this shows how only one instance of the application can run at any time
open two console windows (.NET 5 must be installed)
"run dotnet" from the consoles:
the first one should enter the forever while loop
the second one should just exit

SEMAPHORE:
Open three console windows and do 
"run dotnet"
On the fourth instance, the program should not go further

