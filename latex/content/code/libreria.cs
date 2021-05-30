using Microsoft.EntityFrameworkCore;

// query che ottiene l'utente con email uguale mauro.pellonara@gmail.com, nel caso piu' utenti abbiano la stessa email ritorna un errore
UserDTO user = _context.Users.Single(x => x.Email == "mauro.pellonara@gmail.com");

// equivalente SQLite3
// SELECT * FROM Users WHERE Users.Email = "mauro.pellonara@gmail.com" LIMIT 1;