using User;

User.User usuario = new User.User();

usuario.Fullname = "José Nascimento";
usuario.Email = "joseeantonioo2000@gmail.com";
usuario.Password = 12345678;

usuario.Login("joseeantonioo2000@gmail.com", 12345678);
Console.WriteLine(usuario.Login);

