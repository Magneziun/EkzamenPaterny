using EkzamenPaterny.Behavioral.ChainOfResponsibility;
using EkzamenPaterny.Behavioral.Command;
using EkzamenPaterny.Behavioral.Interpreter;
using EkzamenPaterny.Behavioral.Iterator;
using EkzamenPaterny.Behavioral.Mediator;
using EkzamenPaterny.Behavioral.Memento;
using EkzamenPaterny.Behavioral.NullObject;
using EkzamenPaterny.Behavioral.Observer;
using EkzamenPaterny.Behavioral.State;
using EkzamenPaterny.Behavioral.Strategy;
using EkzamenPaterny.Behavioral.TemplateMethod;
using EkzamenPaterny.Behavioral.Visitor;
using EkzamenPaterny.Creational.AbstractFactory;
using EkzamenPaterny.Creational.Builder;
using EkzamenPaterny.Creational.FactoryMethod;
using EkzamenPaterny.Creational.Prototype;
using EkzamenPaterny.Creational.Singleton;
using EkzamenPaterny.Structural.Adapter;
using EkzamenPaterny.Structural.Bridge;
using EkzamenPaterny.Structural.Composite;
using EkzamenPaterny.Structural.Decorator;
using EkzamenPaterny.Structural.Facade;
using EkzamenPaterny.Structural.Flyweight;
using EkzamenPaterny.Structural.Proxy;
using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;


namespace SmartCity
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Демонстрация паттернов в системе 'Цифровой город' ===\n");

            // Singleton
            Logger.Instance.Log("Логгер работает");
            ConfigManager.Instance.Get("city");

            // Factory Method
            DeviceFactory droneFactory = new DroneFactory();
            IDevice drone = droneFactory.CreateDevice();
            drone.Activate();

            // Abstract Factory
            ICityInfrastructureFactory factory = new CityAFactory();
            ITransport bus = factory.CreateTransport();
            bus.Move();

            // Builder
            Building building = new BuildingBuilder()
                .SetName("Бизнес-центр")
                .SetFloors(20)
                .SetParking(true)
                .Build();
            building.Describe();

            // Prototype
            ConfigurableDevice proto = new ConfigurableDevice { Id = "1", Model = "X100" };
            var clone = (ConfigurableDevice)proto.Clone();
            Logger.Instance.Log($"Клон: Id={clone.Id}, Model={clone.Model}");

            // Adapter
            INewCamera adapted = new CameraAdapter(new OldCamera());
            adapted.Capture();

            // Bridge
            DeviceBridge light = new SmartLight(new RemoteControl());
            light.Operate();

            // Composite
            City city = new City();
            District district = new District { Name = "Центральный" };
            district.Add(new SimpleBuilding { Address = "ул. Пушкина, Дом калатушкина" });
            city.Add(district);
            city.Display();

            // Decorator
            IService analytics = new AnalyticsService();
            IService loggedAnalytics = new LoggingDecorator(analytics);
            loggedAnalytics.Execute();

            // Facade
            CityFacade facade = new CityFacade();
            facade.StartDay();

            // Flyweight
            var tempType = SensorTypeFactory.GetSensorType("temperature", "C");
            Logger.Instance.Log($"Тип сенсора: {tempType.Type}");

            // Proxy
            IDeviceAccess proxy = new DeviceProxy("User");
            proxy.Access();
            proxy = new DeviceProxy("Admin");
            proxy.Access();

            // Chain of Responsibility
            BaseEventHandler chain = new ValidationHandler();
            chain.SetNext(new SecurityHandler());
            chain.Handle("fire");

            // Command
            ICommand lightCmd = new TurnOnLightCommand();
            lightCmd.Execute();

            // Interpreter
            Context ctx = new Context();
            ctx.Variables["temp"] = 35;
            IExpression expr = new GreaterThanExpression("temp", 30);
            Logger.Instance.Log($"Интерпретатор: temp > 30 = {expr.Interpret(ctx)}");

            // Iterator
            DeviceCollection devices = new DeviceCollection();
            devices.Add(new Drone());
            devices.Add(new Camera());
            foreach (var d in devices) d.Activate();

            // Mediator (исправлено: передаём null вместо this)
            IMediator mediator = new EventMediator();
            mediator.Notify(null, "TestEvent");

            // Memento
            DeviceOriginator originator = new DeviceOriginator { State = "On" };
            var memento = originator.Save();
            originator.State = "Off";
            originator.Restore(memento);
            Logger.Instance.Log($"Состояние после восстановления: {originator.State}");

            // Observer
            EventPublisher publisher = new EventPublisher();
            publisher.Subscribe(new SecurityService());
            publisher.Notify("Движение зафиксировано");

            // State
            DeviceContext deviceCtx = new DeviceContext();
            deviceCtx.State = new OnState();
            deviceCtx.Request();
            deviceCtx.State = new OffState();
            deviceCtx.Request();

            // Strategy
            Navigator nav = new Navigator();
            nav.SetStrategy(new FastestRoute());
            nav.Execute();
            nav.SetStrategy(new ShortestRoute());
            nav.Execute();

            // Template Method
            EventProcessor fireProc = new FireEventProcessor();
            fireProc.Process();

            // Visitor
            IVisitable visitableDrone = new VisitableDrone();
            IVisitor audit = new AuditVisitor();
            visitableDrone.Accept(audit);

            // Null Object
            IHandler nullHandler = new NullHandler();
            nullHandler.Handle();

            Console.WriteLine("\n=== Демонстрация завершена ===");
        }
    }
}