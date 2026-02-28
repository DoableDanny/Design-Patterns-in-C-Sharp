
#region Creational Pattern

#region Factory Method

//using ConsoleApp1.src.DesignPatterns.Creational.FactoryMethod.MyTest;

#endregion

#region Singleton
//using ConsoleApp1.src.DesignPatterns.Creational.Singleton.MyTest;

//var appSettings = AppSettings.GetInstance();
//appSettings.Set("AppName", "Singleton");
//appSettings.Set("Version", "1.0.0");
//Console.WriteLine($"App Name: {appSettings.Get("AppName")}");

//Test.Run();
#endregion

#region Prototype
//using ConsoleApp1.src.DesignPatterns.Creational.Prototype.MyTest;
//var circle = new Circle();
//circle.Radius = 20;
//circle.Draw();
//var rectangle = new Rectangle();
//rectangle.Width = 12;
//rectangle.Height = 6;
//rectangle.Draw();

//var shapeactions = new ShapeActions();
//IShape duplicatedCircle = shapeactions.Duplicate(circle);
//IShape duplicatedRectangle = shapeactions.Duplicate(rectangle);

//Console.WriteLine(duplicatedCircle.GetShapeInfo());
#endregion

#endregion

#region Structural Pattern

#region Bridge => the Device is the bridge
//using ConsoleApp1.src.DesignPatterns.Structural.Bridge.MyTest;
//var lgRemoteControl = new RemoteControl(new LGRadio());
//lgRemoteControl.TurnOn();
//lgRemoteControl.TurnOff();

//var advancedRemoteControl = new AdvancedRemoteControl(new SonyRadio());
//advancedRemoteControl.TurnOn();
//advancedRemoteControl.SetChannel(23);
//advancedRemoteControl.TurnOff();
#endregion

#region Proxy
//using ConsoleApp1.src.DesignPatterns.Structural.Proxy.MyTest;

//var videoList = new VideoList();
//string[] videoIds = { "Starwars 1", "Starwars 2", "Starwars 3", "Starwars 4" };

//foreach (var videoId in videoIds)
//{
//    videoList.Add(new YouTubeVideoProxy(videoId));
//}

//videoList.Watch("Starwars 3");
#endregion

#region Facade
//using ConsoleApp1.src.DesignPatterns.Structural.Facade.MyTest;

//var orderRequest = new OrderRequest();
//var orderservice = new OrderService();
//orderservice.Order(orderRequest);
#endregion

#region Decorator
//using ConsoleApp1.src.DesignPatterns.Structural.Decorator.MyTest;
//var url = "https://mycloudstorage.com";
//var data = "Who is chopping with THREE CHAINSAW!! One of them in each hand, and the last one in their mouth";
//var compress = true;
//var encrypt = false;

//IData cloudData = new CloudData(url);
//if (compress)
//{
//    cloudData = new CompressionDecorator(cloudData);
//}
//if (encrypt)
//{
//    cloudData = new EncryptionDecorator(cloudData);
//}
//cloudData.SaveData(data);
#endregion

#region Flyweight
//using ConsoleApp1.src.DesignPatterns.Structural.Flyweight.MyTest;

//var cropservice = new CropService(new CropIconFactory());

//foreach (var crop in cropservice.GetCrops())
//{
//    crop.Render();
//}
#endregion

#region Composite
//using ConsoleApp1.src.DesignPatterns.Structural.Composite.MyTest;

//var package = new Box();
//var box1 = new Box();
//box1.AddItem(new Mouse(20));
//package.AddItem(box1);

//var box2 = new Box();
//box2.AddItem(new Keyboard(30));
//package.AddItem(box2);

//var box3 = new Box();
//var box4 = new Box();
//box3.AddItem(box4);
//box3.AddItem(new Microphone(40));
//package.AddItem(box3);

//Console.WriteLine($"Total price of all items: {package.GetPrice()} ");  // Should return 90 (20 for the mouse, 30 for the keyboard, and 40 for the microphone)
#endregion

#region Adaptor
//using ConsoleApp1.src.DesignPatterns.Structural.Adapter.MyTest;
//using ConsoleApp1.src.DesignPatterns.Structural.Adapter.MyTest.ThridPartyColorLibrary;

//VideoEditor videoEditor = new VideoEditor(new Video());
//videoEditor.ApplyColor(new RainbowColor(new Rainbow())); // Using the adapter to apply a rainbow color filter to the video
//videoEditor.ApplyColor(new BlackAndWhiteColor()); // Applying a black and white color filter to the video
//videoEditor.ApplyColor(new MidnightPurpleColor()); // Applying a midnight purple color filter to the video
#endregion

#endregion

#region Behavioral Pattern


#region Command

#endregion

#region Memento
//using ConsoleApp1.src.DesignPatterns.Behavioral.Memento.MyTest;

//var editor = new Editor();
//var history = new History(editor);

//editor.Title = "First Title";
//editor.Content = "This is the first content.";
//history.Backup();

//Console.WriteLine($"{editor.Title} : {editor.Content}");
//editor.Title = "Second Title";
//editor.Content = "This is the second content.";
//Console.WriteLine($"{editor.Title} : {editor.Content}");
//history.Backup();

//history.Undo();
//Console.WriteLine($"Undo");
//Console.WriteLine($"{editor.Title} : {editor.Content}");
//editor.Title = "New Title";
//editor.Content = "New content.";
//Console.WriteLine($"{editor.Title} : {editor.Content}");

//history.Backup();
//editor.Title = "Start Wars";
//editor.Content = "Once upon a time in a galaxy far far away.";
//Console.WriteLine($"{editor.Title} : {editor.Content}");
//history.Backup();

//history.ShowHistory();
#endregion

#region Mediator
//using ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.MyTest;

//var postDialogBox = new PostDialogBox();
//postDialogBox.SimulateUserInteraction();
#endregion

#region Observer
//using ConsoleApp1.src.DesignPatterns.Behavioral.Observer.MyTest;

//DataSource dataSource = new DataSource();
//Sheet2 sheet2 = new Sheet2(dataSource);
//BarChart barChart = new BarChart(dataSource);
//Sheet3 sheet3 = new Sheet3(dataSource);

//dataSource.AddObserver(sheet2);
//dataSource.AddObserver(barChart);
//dataSource.AddObserver(sheet3);
//dataSource.SetValues(new List<int> { 10, 20, 30 });
//dataSource.SetValues(new List<int> { 5, 10, 15 });
#endregion

#region Iterator
//using ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.MyTest;
//using System.Runtime.CompilerServices;
//ShoppingList shoppingList = new ShoppingList();
//shoppingList.Push("Bread");
//shoppingList.Push("Milk");
//shoppingList.Push("Cola");

//var iterator = shoppingList.CreateIterator();

//PrintList(shoppingList);
//shoppingList.Pop();
//PrintList(shoppingList);
//void PrintList(ShoppingList shoppingList)
//{
//    iterator.Reset();
//    while (iterator.HasNext())
//    {
//        Console.WriteLine(iterator.Current());
//        iterator.Next();
//    }
//}
#endregion

#region ChainOfResponsibility
//using ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest;

//var validator = new Validator();
//var authenticator = new Authenticator();
//var logger = new Logger();

//validator.SetNext(authenticator).SetNext(logger);

//WebServer webServer = new WebServer(validator);
//HTTPRequest request = new HTTPRequest("Leif", "123");
//webServer.Handle(request);

#endregion
#endregion

Console.ReadLine();