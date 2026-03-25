

## mart City Infrastructure: Демонстрация паттернов проектирования
Этот проект представляет собой комплексную реализацию различных паттернов проектирования в контексте инфраструктуры «умного города». Здесь показано, как порождающие, структурные и поведенческие паттерны могут сочетаться для создания гибкой, поддерживаемой и масштабируемой системы.

# Структура проекта
Код разделён на три основные категории паттернов:

Порождающие (Creational) – отвечают за создание объектов.

Структурные (Structural) – обеспечивают построение сложных структур из классов и объектов.

Поведенческие (Behavioral) – управляют взаимодействием и распределением обязанностей между объектами.

Каждый паттерн реализован в виде набора классов с явно выраженными связями. Точка входа – Program.cs – демонстрирует совместную работу всех компонентов.

<img width="1266" height="1105" alt="image" src="https://github.com/user-attachments/assets/292cc0d5-803a-4593-a12f-237169682ac9" />

# Используемые паттерны проектирования
Порождающие
Абстрактная фабрика – DeviceFactory, CityAFactory

Фабричный метод – DroneFactory, CameraFactory

Строитель – BuildingBuilder

Прототип – DevicePrototype, ConfigurableDevice

Одиночка – Logger, ConfigManager (неявно используется повсеместно)

Структурные
Адаптер – CameraAdapter

Мост – DeviceBridge, SmartLight, IControlMode

Компоновщик – City, District, SimpleBuilding

Декоратор – ServiceDecorator, LoggingDecorator

Фасад – CityFacade

Заместитель – DeviceProxy, RealDevice

Поведенческие
Цепочка обязанностей – EventHandler, ValidationHandler, SecurityHandler

Команда – ICommand, TurnOnLightCommand, SendDroneCommand

Интерпретатор – IExpression, GreaterThanExpression

Итератор – DeviceCollection (реализован неявно)

Посредник – IMediator, EventMediator

Хранитель – DeviceMemento, DeviceOriginator

Наблюдатель – IObserver, SecurityService, EventPublisher

Состояние – DeviceState, OnState, OffState, DeviceContext

Стратегия – IRoutingStrategy, FastestRoute, ShortestRoute, Navigator

Шаблонный метод – EventProcessor, FireEventProcessor

Посетитель – IVisitor, AuditVisitor, IVisitable, VisitableDrone

Пустой объект – NullHandler



