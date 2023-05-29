# Labb5–MSUnit

Detta är en lab som handlar om att ta ett gammalt projekt vi har jobbat med och skriva tester på funktionerna. 

##Login
En av de första stegen jag tänkte att man vill testa är själva inloggnings funktionen som ligger i User klassen. Se till så att man matchar en användares användare namn och lösenord så ska det resultera i att testet blir godkänt. Här kan det gå fel om det tillexempel är stor bokstav när det ska vara liten eller bara ren felskrivning. Det är absolut viktigt att inloggning funkar som det är tänkt då det är första steget för att ens få tillgång till banksystemet. 

##Internal transaction

Jag vill även testa den interna transaktionen, det vill säga att när en användare flyttar pengar från två av sina konton att dessa pengar kommer rätt och uppdatera saldot. 

##LoanLimit
Jag vill även testa functionen LoanLimit som ligger i LoanAccount klassen. Regeln här är att man bara ska kunna ta ett lån på en summa 5 gånger det som finns på kontot. Gör ett test med ett konto som har 1000 och förvänta dig att summan ska vara 5000, då vet vi att testet blir godkänt. 

##GeneratUser 
Jag gjorde även ett litet test för att kolla att när vi generar användare att det är fyra som skapas när vi startar programmet.  
