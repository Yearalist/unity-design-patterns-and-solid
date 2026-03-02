# 🎮 Unity Design Patterns & SOLID Principles

Practical, hands-on examples of **Design Patterns** and **SOLID Principles** implemented in Unity/C#.  
Each topic includes a **bad example** (how NOT to do it) and a **good example** (the correct approach), with clear comments explaining the reasoning behind each decision.

---

## 📚 Table of Contents

- [About](#about)
- [Project Structure](#project-structure)
- [SOLID Principles](#solid-principles)
- [Design Patterns](#design-patterns)
- [UniTask](#unitask)
- [How to Run](#how-to-run)
- [Key Takeaways](#key-takeaways)

---

## About

This project was built as a learning resource to demonstrate clean code architecture in Unity game development. Every concept is implemented with:

- **Bad Example** — Shows the common mistake or anti-pattern
- **Good Example** — Shows the correct, maintainable approach
- **Inline Comments** — Every script is thoroughly commented for learning purposes
- **Separate Scenes** — Each topic has its own scene for isolated testing

---

## Project Structure

```
Assets/
├── _SOLID/
│   ├── S_SingleResponsibility/
│   │   ├── Bad/          → God Class (all logic in one file)
│   │   └── Good/         → Separated into Movement, Health, Attack, Upgrade
│   ├── O_OpenClosed/
│   │   ├── Bad/          → Giant if-else chain for weapons
│   │   └── Good/         → IWeapon interface with extensible weapon classes
│   ├── L_LiskovSubstitution/
│   │   ├── Bad/          → TrapEnemy forced to implement Move()
│   │   └── Good/         → IEnemy + IMovableEnemy separation
│   ├── I_InterfaceSegregation/
│   │   ├── Bad/          → One fat INPCBad interface for all NPCs
│   │   └── Good/         → ITalkable, ITradeable, IFightable, IPatrollable
│   └── D_DependencyInversion/
│       ├── Bad/          → GameManager hardcoded to specific notification classes
│       └── Good/         → INotificationService with swappable implementations
│
├── _DesignPatterns/
│   ├── Singleton/                    → GameManager singleton with duplicate protection
│   ├── ObserverPattern_EventBus/     → Central event system with subscribe/publish
│   ├── StatePattern/                 → Woodcutter character with state machine
│   ├── ObjectPool/                   → Bullet pooling vs Instantiate/Destroy
│   └── FactoryPattern/              → Enemy factory vs manual creation
│
└── _UniTask/                         → Async/await examples, parallel loading, cancellation
```

---

## SOLID Principles

### S — Single Responsibility Principle
> A class should have only one reason to change.

**Bad:** `CharacterGodClass.cs` — One class handles movement, health, attack, and upgrades.  
**Good:** `CharacterMovement.cs`, `CharacterHealth.cs`, `CharacterAttack.cs`, `CharacterUpgrade.cs` — Each class has a single responsibility.

**Scene:** `SRP_Example`

---

### O — Open/Closed Principle
> Open for extension, closed for modification.

**Bad:** `WeaponManagerBad.cs` — Adding a new weapon requires modifying existing code with more if-else blocks.  
**Good:** `IWeapon` interface + individual weapon classes — New weapons are added by creating new classes, no existing code is touched.

**Scene:** `OCP_Example`

---

### L — Liskov Substitution Principle
> Subtypes must be substitutable for their base types.

**Bad:** `TrapEnemyBad` inherits `Move()` but throws an exception because traps can't move.  
**Good:** `IEnemy` for all enemies + `IMovableEnemy` only for those that can move. No broken contracts.

**Scene:** `LSP_Example`

---

### I — Interface Segregation Principle
> Clients should not be forced to depend on interfaces they don't use.

**Bad:** `INPCBad` forces Villager to implement `Trade()`, `Fight()`, `Patrol()` — all empty or throwing warnings.  
**Good:** `ITalkable`, `ITradeable`, `IFightable`, `IPatrollable` — Each NPC implements only what it can actually do.

**Scene:** `ISP_Example`

---

### D — Dependency Inversion Principle
> Depend on abstractions, not concretions.

**Bad:** `GameManagerBad` directly creates and uses `ConsoleNotification` and `UINotification`.  
**Good:** `GameManagerGood` depends on `INotificationService` interface — any notification system can be plugged in.

**Scene:** `DIP_Example`

---

## Design Patterns

### Singleton Pattern
> Ensures a class has only one instance and provides global access.

`GameManager` singleton with duplicate protection, `DontDestroyOnLoad`, and global access via `GameManager.Instance`. Includes a test script that proves duplicates are destroyed.

**Scene:** `Singleton_Example` | **Keys:** K (score), P (pause), R (reset), I (info)

---

### Observer Pattern (Event Bus)
> Objects subscribe to events and get notified when something happens.

Central `EventBus` system with `Subscribe`, `Unsubscribe`, and `Publish` methods. When an enemy dies, Score, UI, and Sound systems all react independently without knowing about each other.

**Scene:** `Observer_Example` | **Keys:** K (kill enemy), M (toggle sound)

---

### State Pattern
> An object changes its behavior based on its internal state.

Woodcutter character that cycles through states: Idle → MoveToTree → ChopTree → CollectWood → ReturnToBase → Idle. Each state is a separate class implementing `IState` interface.

**Scene:** `State_Example` | **Keys:** Space (start cycle)

---

### Object Pool Pattern
> Reuse objects instead of creating and destroying them repeatedly.

Bullet pooling system that pre-creates bullets and reuses them. Includes comparison between bad approach (Instantiate/Destroy every time) and good approach (pool-based reuse).

**Scene:** `ObjectPool_Example` | **Keys:** B (bad shoot), G (good shoot)

---

### Factory Pattern
> Centralize object creation in a dedicated factory class.

`EnemyFactory` that produces Goblin, Skeleton, and Dragon enemies with standardized stats. Compared against manual creation with hardcoded values scattered across scripts.

**Scene:** `Factory_Example` | **Keys:** 1 (Goblin), 2 (Skeleton), 3 (Dragon), W (wave)

---

## UniTask

### Async/Await in Unity
> Modern alternative to Coroutines with better performance, cancellation, and return values.

Includes four examples:

- **Coroutine vs UniTask** — Same task, different approaches
- **Cancellation** — Stop async operations mid-execution
- **Return Values** — Get data back from async methods (impossible with Coroutines)
- **Parallel Execution** — Run multiple tasks simultaneously (7s sequential vs 3s parallel)

**Scene:** `UniTask_Example` | **Keys:** C (coroutine), U (unitask), X (cancel), V (values), S (sequential), P (parallel)

---

## How to Run

1. Clone this repository
2. Open the project with **Unity 2022.3 LTS** or later
3. Navigate to any scene inside the topic folders
4. Press **Play** and use the keyboard shortcuts listed above
5. Watch the **Console** window for detailed logs

### Requirements
- Unity 2022.3 LTS or newer
- UniTask package (installed via Package Manager)

---

## Key Takeaways

| Principle / Pattern | Core Idea | Analogy |
|---|---|---|
| Single Responsibility | One class = One job | Restaurant: chef cooks, waiter serves |
| Open/Closed | Add features without changing existing code | Phone: install apps without rewiring |
| Liskov Substitution | Subtypes must work wherever parent works | Taxi driver's son can also drive the taxi |
| Interface Segregation | Small, focused interfaces | Separate contracts for each restaurant role |
| Dependency Inversion | Depend on interfaces, not concrete classes | USB-C standard: any charger fits any phone |
| Singleton | Only one instance, globally accessible | One school principal for the entire school |
| Observer / Event Bus | Publish events, listeners react | Radio station: broadcast, listeners tune in |
| State Pattern | Behavior changes based on current state | Washing machine: wash → rinse → spin |
| Object Pool | Reuse instead of create/destroy | Restaurant trays: wash and reuse |
| Factory | Centralized object creation | Toy factory: order what you want |
| UniTask | Async without freezing the game | Smart waiter: takes order, serves other tables |

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
