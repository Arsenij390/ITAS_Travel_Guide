## CI/CD Pipeine
Workflow - файл `.github/Workflow/main.yml`
  * Сборка: запускается при пуше через GitHub Desktop.
  * Деплой: проект Unity публикуется на GitHub Pages

## Используемые секреты для GitHub Actions (CI/CD)
 * `UNITY_LECENSE` - лицензия Unity
 * `UNITY_EMAIL` - *email* для авторизации в unity
 * `UNITY_PASSWORD` - *пароль* для входа в unity
 * `GH_TOKEN` - токен для деплоя (формируется автоматически)

## Состав папок в репозитории
### **Обязательные**
- ThisProject
  - Assets/
    ```
    - Scenes/ # Сцены (.unity)
    - Scripts/ # C# - скрипты
    - Models/ # 3D-модели (.fbx, .object, .prefab)
    - Materials/ # Материалы и текстуры объектов
    - UI/ # Интерфейсы (шрифты и спрайты)
    ```
  - ProjectSettings/ # Настройки проекта
  - Packages/ # Список пакетов
    
### **Исключить из Git**
```
/Library
/obj
/UserSettings
*.csproj
/.vs
```
