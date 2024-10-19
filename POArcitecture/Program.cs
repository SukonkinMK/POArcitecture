// See https://aka.ms/new-console-template for more information

using POArcitecture;

Editor3D editor3D = new Editor3D();

Console.WriteLine("Открыть проект");
editor3D.OpenProject("myproj.txt");
Console.WriteLine();

Console.WriteLine("Настройки проекта");
editor3D.ShowProjectSettings();
Console.WriteLine();

Console.WriteLine("Печать всех моделей проекта");
editor3D.PrintAllModels();
Console.WriteLine();

Console.WriteLine("Печать всех текстур проекта");
editor3D.PrintAllTextures();
Console.WriteLine();

Console.WriteLine("Рендер всех моделей проекта");
editor3D.RenderAll();
Console.WriteLine();

Console.WriteLine("Рендер модели #1 проекта");
editor3D.RenderModel(1);
Console.WriteLine();