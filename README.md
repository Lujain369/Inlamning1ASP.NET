
ASP.NET CORE är ett utvecklings-plattform som är cross-platform, den funkar på olika typer av enheter och operativsystem.
Det används till att skapa webbapplikationer gratis med inbyggd källkodsram. Det finns olika templates man kan välja mellan för 
oilka användingsområden och hur mycket kod man vill ha gratis.

STARTUP.CS är en klass som finns i ett ASP .NET Core projekt och som innehåller metoder som kallas på när programmet sätts igång, 
men när progarmmets host har byggts upp. I ConfigureServices metoden som finns i startup.cs klassen används service parametern för att lägga till services i programmet, 
exempel på vad den lägger till är razor pages och ens databas, den skapar en connection där till sin databas med hjälp av ens databas-context klass i mappen Data.
Configure metoden i startup.cs klassen används för att svara på programmets http-requests.

WWWROOT är en mapp och den innehåller alla programmets statiska filer, så som css, javascript, bilder och scripts.

RAZOR-SPRÅKET används i ASP.NET Core och är ett programspråk som kombinerar C# och HTML, som också är två oilka programspråk. 
När man startar programmet så omvandlas all kod man har skrivit till bara HTML. Man kan skriva forloopar och @ med razor språket.
@ som används ofta i content-pages och är för att skriva C# kod i HTML kod. Man kan forsätta koda i C# och 
göra ett block av kod med hjälp av "{}" dessa, men det funkar också att lägga till Html element direkt inuti c# kod.

RAZOR PAGES består av två filer, en content-page och en page-model. Båda pages är kopplade till varandra, page-model 
kan bestämma vad som ska stå i content-page och content-page bestämmer vilken model som används i page-model, med hjälp av @model. 
Alla propertys i page-model kommer man åt genom content-page, page-model bestämmer också vad som ska ske och postas när sidan laddas, detta sker i onget och onpost-metod.

MVC står för Model-View-Controller. 
I model skapar man modell-klasser med properties som kopplas till databasen. 
View handlar om UI(User interface) , det som är synligt för användaren. 
Controller tar hand om request som skickas av användaren, dett sker när användaren är i en view sidan.
