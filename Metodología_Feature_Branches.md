## 🧭 Metodología de trabajo con ramas *feature*

### 🎯 Objetivo
Adoptamos un flujo de trabajo ágil y ordenado en Git, donde cada cambio o mejora se desarrolla en una **rama corta independiente** (*feature branch*), que se **elimina una vez integrada al `main`**.  

Este enfoque permite:
- Mantener el `main` siempre **estable y funcional**.  
- Facilitar la **revisión de código y control de versiones**.  
- Evitar conflictos y ramas obsoletas.

---

## 🔧 Flujo de trabajo

### 1️⃣ Crear una rama por feature
Cada desarrollador crea una nueva rama desde `main` para la tarea específica que va a realizar.

```bash
git checkout main
git pull origin main
git checkout -b feature/nombre-breve-del-cambio
```

**Ejemplos:**
- `feature/login-api`
- `feature/ajuste-ui-dashboard`
- `feature/validacion-turnos`

---

### 2️⃣ Desarrollar dentro de la rama
Todo el código, commits y pruebas relacionadas con esa tarea deben realizarse **solo dentro de la rama feature**.

```bash
git add .
git commit -m "Agrega validación de login"
```

---

### 3️⃣ Subir la rama al repositorio remoto
Cuando el desarrollo está probado localmente:

```bash
git push origin feature/nombre-breve-del-cambio
```

---

### 4️⃣ Crear un Pull Request (PR)
1. Abrí un PR desde tu rama `feature/...` hacia `main`.  
2. Solicitá revisión a otro integrante del equipo.  
3. Asegurate de que los tests y builds pasen correctamente (si aplican).

---

### 5️⃣ Merge y eliminación
Una vez aprobado el PR:

1. Se realiza el **merge al `main`**.  
2. Se **elimina la rama feature** (remota y local).  

```bash
# Eliminar rama local
git branch -d feature/nombre-breve-del-cambio

# Eliminar rama remota
git push origin --delete feature/nombre-breve-del-cambio
```

Esto mantiene el repositorio limpio y actualizado.

---

## 💡 Buenas prácticas
- Mantené las ramas **pequeñas y específicas** (una por funcionalidad o bugfix).  
- **No trabajes directamente sobre `main`.**  
- Usá prefijos según el tipo de tarea:
  - `feature/` → nueva funcionalidad  
  - `fix/` → corrección de errores  
  - `hotfix/` → arreglos urgentes en producción  
- Sincronizá frecuentemente con `main` para evitar conflictos:

```bash
git fetch origin
git rebase origin/main
```

- Revisá y aprobá los PRs antes del merge.

---

## 🚀 Beneficios del flujo
- Mayor trazabilidad y orden en el desarrollo.  
- Repositorio limpio y sin ramas huérfanas.  
- Facilita la colaboración y revisión de código.  
- Reduce el riesgo de romper el `main` o generar conflictos grandes.  

---

💬 **En resumen:** cada cambio viaja en su propia rama, se revisa, se integra al `main` y la rama se elimina.  
Simple, limpio y eficiente.
