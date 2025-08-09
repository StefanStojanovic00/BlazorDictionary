# MySimpleDictionaryApp

## Opis projekta

**MySimpleDictionaryApp** je Blazor Server aplikacija koja demonstrira upotrebu sopstvene implementacije generičke kolekcije `MySimpleDictionary<TKey, TValue>`. Aplikacija koristi MudBlazor za moderan i responzivan korisnički interfejs.
---

## Glavne komponente

### MySimpleDictionary<TKey, TValue>

- Generička hash mapa slična .NET `Dictionary`, implementirana od nule.
- Podržava dodavanje, pronalaženje, brisanje, enumeraciju, i automatsko proširenje kapaciteta.
- Koristi strukturu sa bucket-ovima i nizom entiteta za efikasno skladištenje podataka.

### MySimpleDictionaryService

- Servis koji enkapsulira `MySimpleDictionary<string, string>`.
- Omogućava pristup metodama za upravljanje unosa u dictionary.
- Ima događaj `OnChange` za obaveštavanje UI komponenti o promenama.

### Blazor UI komponente

- **AddEntry.razor** — forma za dodavanje novog unosa (ključ-vrednost) u dictionary, sa validacijom i prikazom greške.
- **ViewEntries.razor** — tabela sa prikazom svih unosa i opcijama za uklanjanje pojedinačnih ili svih unosa.

---

## Tehnologije i biblioteke

- Blazor Server
- MudBlazor UI biblioteka (Ova aplikacija je razvijena koristeći .NET 5, zbog čega nije korišćen MudDataGrid, koji nije u potpunosti podržan u MudBlazor verzijama za .NET 5. Umesto toga, koristi se MudTable, koja je kompatibilna sa .NET 5 okruženjem.)
- C# (.NET 5+)

---
## Koriscenje

![Popunjena tablica](https://github.com/user-attachments/assets/1b8c644c-2424-43ce-b863-e11373a5928b)

---

![Obrisan kljuc 123](https://github.com/user-attachments/assets/ed0a837e-3b15-47bc-b2ba-fc891d8d2a82)

---

![Pokusaj dodavanja istog kljuca 2024](https://github.com/user-attachments/assets/df025fa0-e7b7-4de0-936d-e52d1d7c5474)

---

![Brisanje svih elemenata](https://github.com/user-attachments/assets/0ea268ff-98e8-45a8-8674-e749af049dcf)

---






