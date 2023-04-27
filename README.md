# eGym

## Biznis logika

Postoje tri vrste korisnika i to: User, Employee i Admin. Za CRUD operacije sa Employee i Admin accountima potrebno je korisiti /Employee endpointe,
dok sa User accountima potrebno je koristit /Accoount endpointe.

Kreiranje rezervacije se vrsi pomocu /Reservation endpointa, gdje potrebno proslijediti korektne accountId i EmployeeId (Uposlenika kod kojeg zelimo rezervirati termin)
Kada se izvrsi kreiranje Rezervacije ona ima status Pending, te nakon toga je potrebno da Employee potvrdi ili odbije rezervaciju preko jednog od ponudjenih endpointa

Kada Employee potvrdi rezervaciju tek tada je moguce da korisnik izvrsi placanje rezervacije(cijene rezervacije nisu bitne i mozemo ih zakucati na 10KM).

Da bi korisnik izvrsio placanje potrebno je da posjeduje profil kreiran na Stripe payment provideru ukoliko nema kreiran korisiti endpoint <img width="369" alt="image" src="https://user-images.githubusercontent.com/37342503/234953447-e8e7eaab-6e0c-4f8c-8147-00caf4ec28b7.png">

Nakon sto se kreira profil, prisutpa se placanju rezervacije <img width="460" alt="image" src="https://user-images.githubusercontent.com/37342503/234953569-620a4410-475f-4c49-9a9e-c39a874dcc8c.png">
