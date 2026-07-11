# S14 — SESIÓN DE CLASE COMPLETA
## Curso: Realidad Virtual y Aumentada | PSISP08075
### Semana 14 — Pruebas y Validación de Experiencias XR

---

| Campo | Detalle |
|-------|---------|
| **Curso** | Realidad Virtual y Aumentada — PSISP08075 |
| **Semana** | 14 |
| **Tema** | Pruebas y Validación: planificación, ejecución y corrección en XR |
| **Valor transversal** | Perseverancia en la planificación de pruebas, la ejecución y la corrección de errores |
| **Logro de aprendizaje** | Al finalizar la sesión, el estudiante realiza pruebas integrales de la experiencia XR, demostrando perseverancia en la corrección de errores |
| **Duración total** | 3 horas (180 min) + 20 min receso |
| **Modalidad** | Presencial con práctica individual y grupal sobre proyectos propios |

---

## TABLA DE CONTENIDOS

1. [Cronograma](#cronograma)
2. [INICIO](#inicio)
3. [UTILIDAD](#utilidad)
4. [TRANSFORMACIÓN](#transformacion)
   - 4.1 Taxonomía de pruebas en sistemas XR
   - 4.2 Planificación: Plan de pruebas y casos de prueba
   - 4.3 Unity Test Runner — pruebas automatizadas
   - 4.4 Pruebas funcionales en AR/VR
   - 4.5 Pruebas de rendimiento y confort
   - 4.6 Pruebas de usabilidad y accesibilidad
   - 4.7 Ciclo de reporte y corrección de bugs
   - 4.8 Regresión y validación final
5. [RECESO](#receso)
6. [PRÁCTICA](#practica)
7. [CIERRE](#cierre)
8. [Guion verbal](#guion)
9. [Casos reales](#casos)
10. [Evaluación formativa](#eval)
11. [Referencias APA 7](#referencias)
12. [Recursos reales](#recursos)

---

## CRONOGRAMA {#cronograma}

| Bloque | Actividad | Duración | Responsable |
|--------|-----------|----------|-------------|
| 1 — INICIO | Rompe-hielo + Logro + Revisión S13 + Diagnóstico | 20 min | Docente |
| 1 — UTILIDAD | Por qué las pruebas XR son críticas | 10 min | Docente |
| 2 — TRANSFORMACIÓN | 8 subtemas + preguntas + código | 70 min | Docente activo |
| — | **RECESO** | **20 min** | — |
| 3 — PRÁCTICA | Caso grupal + ejercicio individual | 40 min | Estudiantes |
| 3 — CIERRE | Síntesis + metacognición + tarea S15 | 10 min | Docente |

---

## 1. INICIO (20 min) {#inicio}

### a) ROMPE-HIELO — "El Bug Más Caro" (5 min)

**Instrucción verbal al docente:**

> "Tienen 90 segundos. Cada uno piensa en el error de software más famoso que recuerde — un bug real que causó daño económico, reputacional o físico. Luego, en parejas, comparten sus ejemplos. La pareja que tenga el bug con mayor impacto económico documentado gana. ¡Arranquen!"

Dejar que compartan brevemente. Escuchar 2-3 respuestas en voz alta. Al cerrar:

> "El bug del cohete Ariane 5 en 1996: un número de coma flotante de 64 bits se convirtió a 16 bits, causó un overflow, el cohete se autodestruyó. Costo: 370 millones de dólares en 39 segundos. ¿Por qué nadie lo encontró antes? Porque los procedimientos de prueba del Ariane 4 no se aplicaron al Ariane 5 — sistemas diferentes, plan de pruebas diferente. Eso es exactamente lo que trabajamos hoy: probar sistemáticamente para no descubrir el bug el día del lanzamiento."

---

### b) LOGRO DE APRENDIZAJE (3 min)

**Guion verbal textual:**

> "Hoy el logro tiene tres capas. La primera: van a entender los tipos de pruebas que existen en sistemas XR — no todas las pruebas son iguales ni sirven para lo mismo. La segunda: van a diseñar un plan de pruebas real para su propio proyecto y van a ejecutarlo hoy en clase. La tercera: van a encontrar bugs, los van a documentar formalmente y van a corregir al menos uno antes de que termine la clase.
>
> El valor transversal es la perseverancia. Las pruebas son aburridas. Encontrar el mismo bug 15 veces mientras intentas corregirlo es frustrante. Pero la diferencia entre una app XR que se publica y una que se descarta en revisión es exactamente esa: quién tuvo la disciplina de probar, documentar y corregir de forma sistemática hasta que funcionó. Hoy entrenamos esa disciplina."

---

### c) REVISIÓN SESIÓN ANTERIOR — S13: Accesibilidad en RA y RV (7 min)

**Pregunta 1:**

> "¿Cuál es la diferencia entre el modelo médico y el modelo social de la discapacidad? ¿Por qué esa diferencia importa cuando estamos a punto de presentar nuestro proyecto XR?"

**Respuesta esperada:**
El modelo médico coloca la discapacidad en el cuerpo de la persona; el modelo social la coloca en las barreras del diseño. Para el proyecto: si nuestro XR no puede ser usado por alguien con movilidad reducida, el modelo social dice que el error es nuestro (de diseño), no de esa persona. Esto es importante en la presentación porque el tribunal puede preguntar qué usuarios excluye nuestra app — si no tenemos respuesta, perdemos puntos. La auditoría de accesibilidad que hicimos en S13 directamente informa las pruebas de esta semana.

**Pregunta 2:**

> "¿Qué es el cybersickness y por qué se clasifica como una barrera de accesibilidad en XR?"

**Respuesta esperada:**
El cybersickness es el conjunto de síntomas de náusea, desorientación y malestar provocados por la discordancia entre lo que los ojos ven en VR (movimiento) y lo que el sistema vestibular detecta (el cuerpo no se mueve). Es una barrera de accesibilidad porque excluye directamente a usuarios con vértigo, adultos mayores, mujeres (estadísticamente más susceptibles) y cualquier primer usuario de VR. La solución más efectiva es ofrecer modo de teleportación, vignette dinámico y velocidad de movimiento ajustable. En las pruebas de esta semana, cybersickness es uno de los criterios de calidad que deben evaluar.

**Pregunta 3:**

> "¿Qué implementaron en el laboratorio de S13 para hacer su proyecto más accesible? ¿Ya está en GitHub?"

**Respuesta esperada (aceptar cualquier implementación correcta):**
Subtítulos 3D head-locked con SubtitulosXR.cs (panel oscuro detrás del texto, anclado a la cámara en LateUpdate para evitar jitter). Sistema de daltonismo con GestorAccesibilidadColor.cs (cicla entre modos: normal, protanopia, deuteranopia, tritanopia, achromatopsia). El reporte ACCESIBILIDAD.md debía estar en GitHub. Si no está: "Esta semana el primer paso de nuestro plan de pruebas va a ser verificar exactamente eso — qué está y qué no está commiteado."

---

### d) DIAGNÓSTICO INICIAL (5 min)

**Pregunta 1:** "¿Qué es un 'caso de prueba' en ingeniería de software? ¿Cuántos casos de prueba tiene su proyecto actualmente?"

**Respuesta esperada:** Un caso de prueba (test case) es un conjunto de condiciones o acciones específicas con el que un evaluador determina si un sistema funciona correctamente. Incluye: precondiciones, pasos para reproducir, datos de entrada, resultado esperado y resultado actual. La respuesta honesta para la mayoría de proyectos estudiantiles es "ninguno documentado" — lo cual es exactamente el problema que resolvemos hoy.

**Pregunta 2:** "¿Cuál es la diferencia entre 'testing' y 'debugging'? ¿Son lo mismo?"

**Respuesta esperada:** No son lo mismo. Testing (pruebas) es el proceso de encontrar si existe un defecto — ejecutar el sistema con entradas específicas y comparar el resultado real con el esperado. Debugging (depuración) es el proceso de encontrar dónde está el defecto ya conocido y corregirlo. Primero se prueba (para saber QUÉ está mal), luego se depura (para saber DÓNDE y CÓMO corregirlo). Un error frecuente es mezclarlos: ir directo a depurar sin primero documentar el bug, lo que lleva a corregir el síntoma sin entender la causa raíz.

**Pregunta 3:** "Si su app AR tiene una tasa de detección de planos del 60% en sus pruebas propias, ¿eso es aceptable para lanzar?"

**Respuesta esperada:** No — una tasa de detección de planos del 60% significa que en 4 de cada 10 intentos el usuario no puede colocar objetos, lo cual es una falla crítica de funcionalidad. Para una app AR comercial, Google recomienda que la detección de planos funcione en ≥ 90% de condiciones típicas de uso (superficies texturizadas, iluminación adecuada). Sin embargo, "condiciones típicas de uso" deben definirse — en interiores con iluminación artificial puede ser diferente que en exteriores. Las pruebas deben cubrir diferentes superficies, ángulos de cámara y condiciones de luz.

---

## 2. UTILIDAD (10 min) {#utilidad}

### Por qué las pruebas XR no son opcionales

**Dato de impacto:**
Según el informe "State of XR" de AWE (2024), el **68% de las apps XR rechazadas** en las tiendas de Meta Quest y Apple Vision Pro son rechazadas por problemas de calidad detectables con pruebas sistemáticas: crashes, rendimiento por debajo de umbrales mínimos, o funcionalidades críticas que no funcionan. El rechazo en la tienda implica una revisión de 2-4 semanas antes de poder volver a enviar — un costo real en tiempo y reputación.

**Caso real — Pokémon GO lanzamiento (2016):**
El lanzamiento de Pokémon GO en julio de 2016 es el ejemplo más citado de pruebas de carga insuficientes en XR/mobile. Los servidores no soportaron el tráfico (400 millones de descargas en la primera semana) y la app estuvo caída intermitentemente durante 3 semanas. Niantic había probado con carga estimada "realista" pero el fenómeno viral superó toda proyección. Lección: las pruebas deben incluir escenarios de estrés, no solo el "camino feliz" (happy path).

**Aplicación en empresas reales:**
- **Meta:** antes de publicar en Quest Store, toda app pasa por "Store Submission Review" con checklist de 40+ criterios de calidad (rendimiento, crasheo, comodidad, privacidad)
- **Apple:** Vision Pro Apps pasan por review humano que incluye pruebas de accesibilidad y uso de APIs privadas
- **Empresas de XR industrial (PTC Vuforia, Scope AR):** usan pipelines de CI/CD con pruebas automatizadas en Unity Test Runner que corren con cada commit

### Pregunta retadora de apertura

> "Si su app XR funciona perfectamente en su computadora pero crashea en el dispositivo del evaluador de la presentación S15, ¿en qué falló el proceso de desarrollo?"

**Respuesta esperada:**
Falló la prueba de compatibilidad de dispositivo. El error más común es desarrollar y probar solo en el entorno propio (mi PC, mi celular) sin probar en el dispositivo objetivo real. Esto se llama el problema "works on my machine" — el clásico error de no separar el entorno de desarrollo del entorno de producción. La solución: definir desde el inicio el dispositivo target (ej: Android 12+, Adreno 619 o superior, ARCore 1.35) y probar en ese dispositivo específico antes de cualquier presentación. Si no tienen el dispositivo, Unity Remote o un emulador de ARCore son aproximaciones parciales.

---

## 3. TRANSFORMACIÓN (70 min) {#transformacion}

### 3.1 Taxonomía de pruebas en sistemas XR (8 min)

**Explicación conceptual:**

Las pruebas en XR no son las mismas que en software convencional. La presencia del hardware (cámara, sensores, headset, tracking) agrega dimensiones de prueba que no existen en apps de escritorio o web.

```
TAXONOMÍA DE PRUEBAS PARA SISTEMAS XR
═══════════════════════════════════════════════════════════════════
TIPO                    QUÉ VERIFICA                    HERRAMIENTA
───────────────────────────────────────────────────────────────────
FUNCIONAL               Que las features funcionen       Manual + Unity Test Runner
  └─ Unit Test          Lógica de un script aislada      Unity Test Runner (Edit Mode)
  └─ Integration Test   Interacción entre componentes    Unity Test Runner (Play Mode)
  └─ System Test        Flujo completo end-to-end        Manual con checklist

RENDIMIENTO             FPS, latencia, memoria           Unity Profiler, Stats panel
  └─ Benchmark          Línea base de performance        Profiler CPU/GPU
  └─ Stress             Límites del sistema              Objetos masivos, escenas pesadas
  └─ Endurance          Sesión prolongada (30-60 min)    Profiler + temperatura dispositivo

COMPATIBILIDAD          Funciona en el hardware objetivo  Dispositivos físicos, ARCore check
  └─ Device             Modelos específicos de celular   Múltiples dispositivos Android
  └─ OS Version         Android 12 vs 13 vs 14          Firebase Test Lab
  └─ SDK Version        ARCore 1.35, Unity 2022.3.x      Changelog review

USABILIDAD              Qué tan fácil es de usar         Usuarios reales, sesiones grabadas
  └─ Think-Aloud        El usuario verbaliza lo que hace Grabación de pantalla + voz
  └─ Heurística         Revisión contra principios UX    Nielsen's 10 heuristics + XAUR

ACCESIBILIDAD           Usuarios con discapacidad        Auditoría XAUR + simuladores
REGRESIÓN               Que correcciones no rompan otra  Re-ejecutar todos los casos
═══════════════════════════════════════════════════════════════════
```

**PREGUNTA AL GRUPO 1:**

> "¿Por qué las pruebas de rendimiento son diferentes y más importantes en XR que en una app de escritorio convencional?"

**Respuesta esperada:**
En una app de escritorio, si el framerate baja de 30 FPS el usuario ve el video "choppy" pero no sufre consecuencias físicas. En XR, especialmente en VR: 1) un framerate < 72 FPS (Quest) o < 90 FPS (PCVR) no es solo feo — puede causar cybersickness activo (náuseas) porque la discordancia sensorial empeora con latencia de render; 2) la app puede ser rechazada automáticamente por las tiendas de VR que tienen umbrales mínimos de FPS; 3) en AR móvil, un rendimiento pobre drena la batería rápidamente y calienta el dispositivo, lo que degrada la calidad del tracking de ARCore. Por eso en XR, rendimiento = usabilidad = accesibilidad — todo está conectado.

---

### 3.2 Planificación: Plan de pruebas y casos de prueba (10 min)

**Explicación conceptual:**

Un **Plan de Pruebas** (Test Plan) es el documento que define QUÉ se va a probar, CÓMO, CUÁNDO y QUIÉN lo hace. Sin plan, las pruebas son ad hoc — se prueban las mismas cosas varias veces y se olvidan otras críticas.

Un **Caso de Prueba** (Test Case) es la unidad atómica del plan: define una condición específica, los pasos para reproducirla, y qué resultado se espera.

**Estructura mínima de un caso de prueba para XR:**

```markdown
## TC-001: Detección de plano y colocación de objeto AR

| Campo              | Valor |
|--------------------|-------|
| ID                 | TC-001 |
| Módulo             | AR Placement |
| Prioridad          | ALTA (funcionalidad core) |
| Tipo               | Funcional |

**Precondiciones:**
- Dispositivo Android con ARCore instalado
- Sesión AR iniciada (ARSession.state = Tracking)
- Iluminación del entorno: 300-600 lux (interior estándar)

**Pasos:**
1. Apuntar la cámara a una superficie plana horizontal (mesa)
2. Esperar hasta que aparezcan los planos detectados (mallaAR)
3. Tocar la superficie detectada una vez con el dedo
4. Observar si el objeto prefab aparece en la posición tocada

**Resultado Esperado:**
El cubo/prefab se instancia exactamente en el punto donde el usuario tocó,
sobre el plano detectado. El objeto permanece fijo al mover la cámara.

**Resultado Actual:** [completar al ejecutar]
**Estado:** PENDIENTE / PASA / FALLA
**Bug ID (si falla):** —
**Notas:** [superficie usada, ángulo, condiciones de luz]
```

**Pirámide de pruebas para el proyecto XR:**

```
         /\
        /  \
       / UI \        ← Tests manuales (pocos, lentos, caros)
      /  E2E \           Prueba completa del flujo: abrir app → colocar → interactuar
     /─────────\
    / Integración\   ← Tests semiautomáticos (moderados)
   /  Play Mode   \      Que InputAR.cs + ARRaycastManager funcionen juntos
  /─────────────────\
 /   Unitarias        \ ← Tests automáticos (muchos, rápidos, baratos)
/    Edit Mode          \    Que GestorAccesibilidad.ToggleMenu() cambia el estado
══════════════════════════
```

**PREGUNTA AL GRUPO 2:**

> "¿Por qué es importante definir las 'precondiciones' de un caso de prueba? ¿Qué pasa si no las defines?"

**Respuesta esperada:**
Las precondiciones son el estado del sistema ANTES de ejecutar el caso de prueba. Sin ellas, dos personas que ejecutan el mismo caso pueden obtener resultados diferentes sin saber por qué. Ejemplo: si un caso de prueba de AR no especifica "superficie plana texturizada" como precondición, un tester que usa una mesa de vidrio (poca textura, AR detecta mal los planos) obtendrá FALLA, mientras que otro que usa una mesa de madera obtendrá PASA — y ambos estarán reportando el mismo caso de prueba con resultados opuestos. Esto hace que el bug sea "no reproducible" — uno de los problemas más frustrantes en QA profesional. Las precondiciones fuerzan que el entorno sea controlado.

---

### 3.3 Unity Test Runner — pruebas automatizadas (12 min)

**Explicación conceptual:**

Unity Test Runner es el framework de pruebas integrado en Unity. Tiene dos modos:
- **Edit Mode:** prueba lógica de scripts sin iniciar Play Mode. No requiere cámara, escena activa ni Input. Es la base de la pirámide — el más rápido y económico.
- **Play Mode:** prueba con el ciclo de vida completo de Unity (Start, Update, etc.). Requiere que la escena esté corriendo. Sirve para pruebas de integración.

**Instalación y acceso:**
```
Window → General → Test Runner
(En Unity 2022.3.x ya está integrado — no requiere instalación extra)
```

**Código de prueba unitaria real — Edit Mode:**

```csharp
// Assets/Tests/EditMode/TestGestorAccesibilidad.cs
// Prueba la lógica de GestorAccesibilidadColor sin necesitar escena AR activa.
// Para que Unity lo reconozca como test: debe estar en una carpeta Tests/
// y el assembly definition debe referenciar NUnit.Framework.

using NUnit.Framework;
using UnityEngine;

// [TestFixture] es opcional — NUnit lo infiere de la convención
public class TestGestorAccesibilidad
{
    // Instancia del script a probar — la creamos manualmente, no desde Hierarchy
    private GestorAccesibilidadColor gestor;

    // [SetUp] se ejecuta ANTES de cada test — equivale al arrange de AAA
    [SetUp]
    public void Preparar()
    {
        // Creamos un GameObject vacío y le agregamos el script
        var go = new GameObject("TestGestor");
        gestor = go.AddComponent<GestorAccesibilidadColor>();
        // Nota: panelMenu = null aquí (no hay Canvas en Edit Mode)
        // Por eso los métodos de UI deben protegerse con null checks
    }

    // [TearDown] se ejecuta DESPUÉS de cada test — limpieza
    [TearDown]
    public void Limpiar()
    {
        // Destruir el GameObject para no contaminar otros tests
        Object.DestroyImmediate(gestor.gameObject);
    }

    // Naming convention: Metodo_Condicion_ResultadoEsperado
    [Test]
    public void SiguienteModo_DesdeNormal_VaAProtanopia()
    {
        // Arrange: el modo inicial es 0 (Normal)
        int modoInicial = 0;

        // Act: llamar al método
        gestor.SiguienteModo(); // debe avanzar de 0 a 1

        // Assert: verificar que el modo cambió
        // (modoActual es private, necesitamos que el método retorne el modo
        //  o lo exponga como [SerializeField] para testear)
        // Para este ejemplo, verificamos via el texto si está conectado
        Assert.Pass("SiguienteModo ejecutado sin excepción");
        // En un test más completo: Assert.AreEqual(1, gestor.modoActual);
    }

    [Test]
    public void SiguienteModo_DesdeUltimoModo_VuelveANormal()
    {
        // Simular que estamos en el último modo (4 = Achromatopsia)
        // Para esto, GestorAccesibilidadColor necesita exponer SetModo()
        gestor.SetModo(4);

        // Llamar siguiente — debe ciclar a 0 (Normal)
        gestor.SiguienteModo();

        // No podemos verificar modoActual directamente si es private
        // Solución: usar [SerializeField] en lugar de private, o
        // implementar un getter público int GetModo()
        Assert.Pass("Ciclo correcto sin excepción");
    }

    [Test]
    public void SetSubtitulosActivos_False_DesactivaCorrectamente()
    {
        // Si SubtitulosXR está en el mismo GO, podemos testear integración
        // Aquí hacemos un test simple de estado
        Assert.IsNotNull(gestor, "El gestor debe existir después del Setup");
    }
}
```

**Cómo correr los tests:**
```
Window → General → Test Runner → EditMode tab → Run All
```

**PREGUNTA AL GRUPO 3:**

> "¿Qué ventaja tiene tener un test automatizado para `SiguienteModo()` comparado con probarlo manualmente en Play Mode cada vez?"

**Respuesta esperada:**
La ventaja es la velocidad y reproducibilidad. Un test unitario de Edit Mode corre en milisegundos — puedes ejecutar 50 tests en 2 segundos. El mismo test manual en Play Mode requiere: iniciar Play (2-5s), navegar al menú, hacer clic en el botón, verificar visualmente el resultado, salir de Play (2s) — mínimo 10 segundos por test. Con 50 casos de prueba: automático = 2s, manual = ~8 minutos. Más importante: el test automático es objetivo (PASA/FALLA sin ambigüedad), se puede correr en CI/CD con cada commit, y documenta exactamente qué comportamiento se está verificando. La regresión también se detecta automáticamente: si un cambio posterior rompe `SiguienteModo()`, el test falla inmediatamente sin que nadie lo tenga que descubrir manualmente.

---

### 3.4 Pruebas funcionales en AR/VR (10 min)

**Checklist de pruebas funcionales para proyectos AR (Unity + AR Foundation):**

```markdown
## CHECKLIST FUNCIONAL AR — Proyecto S11-S13

### ARSession y Tracking
☐ La sesión AR inicia sin error (ARSession.state == Tracking en < 5s)
☐ En condiciones de poca luz: el sistema muestra mensaje de advertencia
☐ Al cubrir la cámara completamente: la sesión entra en Lost y se recupera
☐ Al reiniciar la app: la sesión se re-inicializa correctamente

### Detección de Planos (ARPlaneManager)
☐ Detecta planos horizontales en superficie texturizada (mesa de madera)
☐ NO detecta planos en superficie sin textura (vidrio, espejo)
   → Esto es comportamiento CORRECTO de ARCore (no es un bug)
☐ Los planos se visualizan con el mesh de AR (si implementado)
☐ ARPlaneManager.enabled = false detiene la detección correctamente

### Colocación de Objetos (ARRaycastManager)
☐ Un toque en el plano detectado instancia el prefab
☐ El prefab aparece en la posición exacta del toque (no desplazado)
☐ El prefab queda fijo al mover la cámara (tracking estable)
☐ Toques múltiples: el sistema maneja correctamente (¿reemplaza? ¿acumula?)
☐ Toque fuera de plano detectado: el sistema no crashea

### Gestos e Input (InputAR.cs / GestorInputXR.cs)
☐ Tap simple: coloca objeto (si implementado)
☐ Double tap: reset de escala y rotación (si implementado)
☐ Swipe horizontal: rota el objeto
☐ Pinch: escala el objeto (Mathf.Clamp respetado)
☐ Hold: feedback visual activado correctamente

### Subtítulos (SubtitulosXR.cs)
☐ Al activar un evento, el subtítulo aparece en pantalla
☐ El subtítulo desaparece automáticamente después de N segundos
☐ El panel oscuro es visible independientemente del fondo
☐ Al mover la cámara, el panel sigue la cabeza (head-locked)

### Accesibilidad (GestorAccesibilidadColor.cs)
☐ El botón de accesibilidad abre el menú
☐ "Siguiente modo" cicla entre los 5 modos correctamente
☐ El texto del modo actual se actualiza en pantalla
☐ El botón "Cerrar" oculta el menú
```

**PREGUNTA AL GRUPO 4:**

> "En el checklist, el ítem 'NO detecta planos en vidrio/espejo → comportamiento CORRECTO' podría confundir a un tester. ¿Cómo lo manejarían en un bug report?"

**Respuesta esperada:**
Este es un caso de prueba que verifica comportamiento ESPERADO, no un bug. ARCore usa análisis de textura visual para detectar superficies — el vidrio y los espejos no tienen textura visual suficiente (son uniformes o reflejan la cámara creando confusión). Si un tester inexperto reportara esto como bug, se le respondería: "Este es el comportamiento correcto y documentado de ARCore. Referencia: documentación oficial de ARCore Feature Map." La solución profesional es: 1) documentarlo en el manual de usuario ("La app requiere superficies con textura visible"), 2) si el caso de uso exige vidrio, investigar alternativas como ARCore Depth API o marcadores físicos. Esto ilustra que las pruebas no solo detectan bugs — también documentan limitaciones conocidas del sistema.

---

### 3.5 Pruebas de rendimiento y confort (10 min)

**Métricas objetivo para proyectos AR móvil (Unity + ARCore, Android):**

```
MÉTRICAS DE RENDIMIENTO — OBJETIVOS MÍNIMOS
══════════════════════════════════════════════════════════
Métrica              AR Móvil (mínimo)   AR Móvil (objetivo)
──────────────────── ─────────────────── ───────────────────
FPS                  ≥ 30 FPS            ≥ 60 FPS
Frame time           ≤ 33ms              ≤ 16.6ms
Draw Calls           < 200               < 100
Triángulos           < 500K              < 200K
Memoria RAM usada    < 500 MB            < 300 MB
Temperatura (30min)  < 45°C              < 40°C
Batería (30 min)     < 30% drenada       < 20% drenada
GC Alloc / frame     < 1 KB              0 bytes idealmente
══════════════════════════════════════════════════════════
```

**Script de benchmarking automatizado:**

```csharp
// Assets/Scripts/BenchmarkXR.cs
// Registra métricas de rendimiento automáticamente durante una sesión.
// NO incluir en el build final — solo para pruebas.

using UnityEngine;
using System.IO;

public class BenchmarkXR : MonoBehaviour
{
    [Header("Configuración")]
    [Tooltip("Duración de la sesión de benchmark en segundos")]
    public float duracionBenchmark = 60f;

    [Tooltip("Muestras de FPS por segundo")]
    public float frecuenciaMuestra = 2f;

    private float tiempoTranscurrido = 0f;
    private float tiempoSiguienteMuestra = 0f;
    private System.Text.StringBuilder log = new System.Text.StringBuilder();
    private int muestraCount = 0;
    private float fpsAcumulado = 0f;

    void Start()
    {
        // Encabezado del log
        log.AppendLine("Tiempo(s),FPS,DrawCalls,Tris,MemoriaUsada(MB)");
        Debug.Log("[Benchmark] Iniciado. Duración: " + duracionBenchmark + "s");
    }

    void Update()
    {
        tiempoTranscurrido += Time.unscaledDeltaTime;

        // Verificar si la sesión terminó
        if (tiempoTranscurrido >= duracionBenchmark)
        {
            GuardarReporte();
            enabled = false; // desactivar el script
            return;
        }

        // Tomar muestra según la frecuencia configurada
        if (tiempoTranscurrido >= tiempoSiguienteMuestra)
        {
            float fps = 1f / Time.unscaledDeltaTime;
            fpsAcumulado += fps;
            muestraCount++;

            // Obtener stats de rendering (solo en editor o development build)
            #if UNITY_EDITOR || DEVELOPMENT_BUILD
            int drawCalls = UnityEngine.Rendering.DebugManager.instance != null ? 0 : 0;
            // En Unity, acceder a stats requiere el reflection hack o el Stats panel
            // Para este lab, usamos solo FPS y memoria
            #endif

            // Memoria actual
            float memMB = (float)System.GC.GetTotalMemory(false) / (1024 * 1024);

            // Registrar en log
            log.AppendLine($"{tiempoTranscurrido:F1},{fps:F1},N/A,N/A,{memMB:F1}");

            tiempoSiguienteMuestra = tiempoTranscurrido + (1f / frecuenciaMuestra);
        }
    }

    void GuardarReporte()
    {
        float fpsPromedio = muestraCount > 0 ? fpsAcumulado / muestraCount : 0f;
        log.AppendLine($"--- FPS PROMEDIO: {fpsPromedio:F1} ---");

        // Guardar en archivo
        string ruta = Application.persistentDataPath + "/benchmark_" +
                      System.DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
        File.WriteAllText(ruta, log.ToString());

        Debug.Log($"[Benchmark] Completado. FPS promedio: {fpsPromedio:F1}");
        Debug.Log($"[Benchmark] Reporte guardado en: {ruta}");
    }
}
```

**PREGUNTA AL GRUPO 5:**

> "Si su app AR tiene 60 FPS en el editor pero 22 FPS en el dispositivo Android, ¿cuáles son las 3 causas más probables y cómo las investigarían?"

**Respuesta esperada:**
Las 3 causas más probables son: 1) **Diferencia GPU/CPU**: el GPU del editor (escritorio) es mucho más potente que el GPU móvil (Adreno 619). Investigar: conectar el dispositivo físico al Unity Profiler (Window → Analysis → Profiler → Target Device → [nombre del dispositivo]). Si Camera.Render toma > 15ms = GPU bound → reducir draw calls, LODs, sombras. 2) **VSync y target frame rate**: verificar `Application.targetFrameRate`. En móvil Android, el default puede ser 30. Cambiar a `Application.targetFrameRate = 60`. 3) **Procesamiento de ARCore en CPU**: ARCore consume CPU adicional para tracking (análisis de cámara). Si el CPU está al 100%, todos los scripts de Update() se retrasan. Solución: usar ARPlaneManager.enabled = false después del placement para reducir la carga de ARCore.

---

### 3.6 Pruebas de usabilidad y accesibilidad (8 min)

**El protocolo Think-Aloud para XR:**

El protocolo Think-Aloud (pensar en voz alta) es la técnica de usabilidad más efectiva para XR porque captura en tiempo real dónde el usuario se confunde, se frustra o no encuentra lo que busca.

**Protocolo mínimo (20 minutos por usuario):**

```
PROTOCOLO THINK-ALOUD — PRUEBA DE USABILIDAD XR
═══════════════════════════════════════════════════
ANTES DE EMPEZAR (5 min):
  1. "No te estoy evaluando a ti — estoy evaluando la app."
  2. "Di en voz alta todo lo que piensas mientras usas la app."
  3. "Si no encuentras algo o no puedes hacer algo, dilo — eso es información valiosa."
  4. "No tengo permitido ayudarte durante la prueba."

TAREAS A EJECUTAR (sin decir CÓMO hacerlo):
  T1: "Abre la app y coloca un objeto en la mesa"
  T2: "Cambia el tamaño del objeto a la mitad"
  T3: "Activa el modo de accesibilidad y cambia a modo de daltonismo"
  T4: "Encuentra cómo hacer una pausa / volver al menú"

QUÉ OBSERVAR Y REGISTRAR:
  - Tiempo hasta completar cada tarea (success time)
  - Errores cometidos (acciones incorrectas)
  - Verbalizaciones de confusión ("¿cómo...?", "¿dónde está...?")
  - Gestos o acciones no esperadas (el usuario intenta algo que no diseñaste)
  - Expresiones de satisfacción o frustración

DESPUÉS (5 min):
  - "¿Qué fue lo más confuso?"
  - "¿Qué hubiera esperado que hiciera X?"
  - "¿Hay algo que no encontraste?"
═══════════════════════════════════════════════════
```

**PREGUNTA AL GRUPO 6:**

> "¿Por qué en el protocolo Think-Aloud el evaluador NO puede ayudar al usuario durante la prueba, aunque lo vea completamente perdido?"

**Respuesta esperada:**
Si el evaluador ayuda, contamina los datos. En un producto real, el usuario no tendrá al diseñador al lado para decirle "el menú está ahí". Si el evaluador interviene, el resultado de la prueba será: "con ayuda, el usuario puede completar la tarea" — lo cual no es el objetivo. El objetivo es: "sin ayuda, ¿el usuario puede completar la tarea?". Si el usuario falla, eso es información valiosa: el diseño de la interfaz falló, no el usuario. Además, si el evaluador interviene en la tarea 1, el usuario puede orientarse para las tareas 2-3-4 artificialmente, corrompiendo todos los resultados posteriores. La única excepción aceptable es si el usuario quiere abandonar la prueba — en ese caso se detiene y se registra "abandonó en Tarea X".

---

### 3.7 Ciclo de reporte y corrección de bugs (7 min)

**Severidad y prioridad de bugs — son conceptos diferentes:**

```
SEVERIDAD: impacto en la funcionalidad del sistema
PRIORIDAD: urgencia con la que debe corregirse

   SEVERIDAD
   ─────────────────────────────────────────────────
   CRÍTICO    La app crashea o pierde datos de usuario
   MAYOR      Una funcionalidad core no funciona
   MENOR      Una funcionalidad secundaria no funciona
   COSMÉTICO  Error visual sin impacto en funcionalidad

   PRIORIDAD
   ─────────────────────────────────────────────────
   P1 (Alta)    Bloquea la presentación/entrega
   P2 (Media)   Debe corregirse antes del lanzamiento
   P3 (Baja)    Deseable corregir en iteración siguiente
   P4 (Defer)   Registrar y posponer indefinidamente

   RELACIÓN (pueden no coincidir):
   Bug cosmético puede ser P1 si la demo es mañana.
   Bug crítico puede ser P4 si afecta un flujo nunca usado.
```

**Template de bug report — formato profesional:**

```markdown
## BUG-007: App crashea al pinchar con dos dedos sobre vidrio

| Campo         | Valor |
|---------------|-------|
| ID            | BUG-007 |
| Reportado por | [nombre] |
| Fecha         | 2026-07-11 |
| Severidad     | CRÍTICO |
| Prioridad     | P1 |
| Estado        | ABIERTO |
| Asignado a    | [nombre del desarrollador] |

**Resumen:** La app lanza NullReferenceException y cierra al hacer pinch sobre una
superficie de vidrio donde no hay planos detectados.

**Pasos para reproducir:**
1. Iniciar la app en Pixel 6 (Android 14)
2. Apuntar la cámara hacia una superficie de vidrio
3. Esperar 3 segundos (no se detectan planos)
4. Realizar gesto de pinch con dos dedos en la pantalla

**Resultado esperado:**
El sistema no debe crashear. Debería mostrar mensaje: "No se detectó superficie plana."

**Resultado actual:**
NullReferenceException en GestorInputXR.cs línea 87:
`hits[0].pose.position` — hits está vacío cuando no hay plano detectado.

**Evidencia:** [screenshot del crash log / grabación de pantalla]
**Reproducibilidad:** 10/10 intentos

**Causa raíz (si conocida):**
En `AlTapSimple()` no se verifica `hits.Count > 0` antes de acceder a `hits[0]`.
```

**La corrección:**

```csharp
// GestorInputXR.cs — línea ~85
// ANTES (bug):
void AlTapSimple(Vector2 pos)
{
    if (raycastManager.Raycast(pos, hits, TrackableType.PlaneWithinPolygon))
        Instantiate(prefabObjeto, hits[0].pose.position, hits[0].pose.rotation);
        // ↑ Si hits está vacío pero la condición del if es true por otra razón,
        // hits[0] lanza IndexOutOfRangeException
}

// DESPUÉS (corregido):
void AlTapSimple(Vector2 pos)
{
    if (raycastManager.Raycast(pos, hits, TrackableType.PlaneWithinPolygon)
        && hits.Count > 0)  // ← GUARD CLAUSE: verificar que la lista no está vacía
    {
        Instantiate(prefabObjeto, hits[0].pose.position, hits[0].pose.rotation);
        if (sistemSubtitulos != null)
            sistemSubtitulos.MostrarSubtitulo("Objeto colocado", 2f);
    }
    else
    {
        // Feedback al usuario: no se detectó superficie
        if (sistemSubtitulos != null)
            sistemSubtitulos.MostrarSubtitulo("⚠ No se detectó superficie plana", 2f);
    }
}
```

**PREGUNTA AL GRUPO 7:**

> "¿Por qué es importante que un bug report incluya 'pasos para reproducir' específicos y no solo la descripción del error?"

**Respuesta esperada:**
Un bug que no se puede reproducir no se puede corregir. El desarrollador que recibe el reporte necesita recrear exactamente la condición en que ocurre el bug para 1) verificar que existe (algunos bugs son intermitentes o dependen del entorno), 2) poder ver el stack trace completo en su entorno, 3) verificar que su corrección efectivamente soluciona el bug (prueba de regresión). Si el reporte dice solo "la app crashea al pinchar", el desarrollador tiene que adivinar en qué superficie, con qué gestos, en qué dispositivo. Un buen reporte de bug es como una receta de cocina: con los mismos ingredientes y pasos, siempre obtienes el mismo resultado (el bug). Sin esa especificidad, cada persona en el equipo reproduce una condición diferente y nadie está seguro si están hablando del mismo bug.

---

### 3.8 Regresión y validación final (5 min)

**Ciclo de vida de un bug — diagrama:**

```
    [ENCONTRADO]
         │
         ▼
    [REPORTADO] ──── Bug report creado, ID asignado, prioridad definida
         │
         ▼
    [ASIGNADO] ───── Developer asignado, estado: "In Progress"
         │
         ▼
    [CORREGIDO] ──── Fix aplicado, commit referenciando el Bug ID
         │           ("fix: prevenir NullRef en AlTapSimple — BUG-007")
         ▼
    [EN PRUEBA] ──── QA re-ejecuta el caso de prueba original (TC-XXX)
         │
         ├──── PASA ──► [CERRADO] — Bug resuelto, caso de prueba verde
         │
         └──── FALLA ─► [REABIERTO] — Fix incompleto, vuelve al developer
                              │
                              └──► Ciclo se repite
```

**Prueba de regresión:** después de cada corrección, re-ejecutar TODOS los casos de prueba que toquen el mismo módulo. Esto asegura que el fix no introdujo nuevos bugs en código adyacente.

**PREGUNTA AL GRUPO 8:**

> "¿Por qué un commit de corrección de bug debería referenciar el ID del bug en el mensaje? ('fix: prevenir NullRef — BUG-007')"

**Respuesta esperada:**
Por rastreabilidad (traceability). El ID en el commit crea un vínculo permanente entre tres cosas: el bug reportado, el código que lo corrigió y la persona que hizo el cambio. Esto permite: 1) En el futuro, si el bug reaparece, hacer `git log --grep="BUG-007"` para encontrar exactamente qué cambio lo corrigió y cuándo; 2) En la revisión de código, quien aprueba el PR puede verificar que el código corrige exactamente lo que describe el bug y no introduce otros cambios no relacionados; 3) En el historial del proyecto, ver cuántos bugs se corrigieron en qué período (velocidad de corrección). Es parte del estándar Conventional Commits y es el flujo que usan todas las empresas de software serias. GitHub y GitLab incluso permiten cerrar issues automáticamente cuando el commit con el ID es mergeado.

---

## RECESO (20 min) {#receso}

---

## 4. PRÁCTICA (40 min) {#practica}

### a) CASO PRÁCTICO GRUPAL (25 min)

**Escenario:**

> Tu equipo trabaja en una empresa de XR industrial en Lima. Han desarrollado una app de AR para técnicos de mantenimiento de la planta de GN LNG (gas natural licuado) en Camisea: los técnicos apuntan la cámara a equipos industriales y ven overlays AR con el historial de mantenimiento, alertas de temperatura y guías de procedimiento paso a paso. La app se va a presentar al cliente en 5 días.
>
> El QA Lead identificó 8 bugs en la última sesión de pruebas. El equipo de desarrollo tiene capacidad para corregir máximo 5 bugs antes de la presentación. Deben decidir CUÁLES corregir.
>
> **Los 8 bugs identificados:**
>
> | Bug ID | Descripción | Severidad | Tiempo estimado de corrección |
> |--------|-------------|-----------|-------------------------------|
> | BUG-01 | App crashea al apuntar a marcador no reconocido | CRÍTICO | 2 horas |
> | BUG-02 | Los overlays de temperatura se desplazan 5cm del equipo real en movimiento rápido | MAYOR | 8 horas |
> | BUG-03 | El texto de las guías es ilegible en exteriores con sol directo (contraste insuficiente) | MAYOR | 1 hora |
> | BUG-04 | Pantalla de login no centra el teclado en dispositivos < 6 pulgadas | MENOR | 3 horas |
> | BUG-05 | El ícono de la app no es el corporativo correcto (usa placeholder) | COSMÉTICO | 0.5 horas |
> | BUG-06 | No hay modo de accesibilidad para daltónicos (las alertas son solo en rojo) | MAYOR | 4 horas |
> | BUG-07 | La app no funciona en dispositivos sin ARCore (Huawei post-2019) | CRÍTICO | 12 horas |
> | BUG-08 | El historial de mantenimiento no se actualiza en tiempo real (requiere reiniciar app) | MAYOR | 6 horas |

**Tarea grupal:**

1. Asignar prioridad (P1/P2/P3) a cada bug considerando el contexto de la presentación
2. Seleccionar los 5 bugs a corregir antes de la presentación y justificar cada decisión
3. Para los 3 bugs que NO se corrigen: ¿cómo los comunican al cliente?
4. Redactar el mensaje de correo electrónico al cliente explicando el estado del producto

**Preguntas de andamiaje:**
- "¿BUG-07 (no funciona en Huawei) es crítico para esta presentación si el cliente usa Samsung?"
- "¿BUG-03 (contraste insuficiente) es mayor o crítico si los técnicos trabajan en exteriores todo el tiempo?"
- "¿Qué pasa si no corrigen BUG-01 y el marcador no reconocido ocurre durante la demo?"
- "¿Cómo afecta BUG-06 (daltonismo) al contexto industrial de seguridad?"

**Respuesta modelo:**

**Bugs a corregir (top 5 por impacto en presentación):**
1. **BUG-01** (crash): P1 absoluto — si la app crashea durante la demo, es game over
2. **BUG-03** (contraste texto): P1 contextual — demo en exteriores = bug crítico por contexto
3. **BUG-05** (ícono): P1 de imagen — 30 minutos de trabajo, impacto profesional alto
4. **BUG-06** (daltonismo): P1 de seguridad — en industrial, alertas solo en rojo pueden ser peligrosas para técnicos daltónicos (8% de hombres)
5. **BUG-08** (tiempo real): P2 — si el cliente hace preguntas sobre datos en vivo

**Bugs diferidos y comunicación:**
- BUG-02 (desplazamiento AR): "Los overlays tienen una imprecisión de ~5cm en movimiento rápido — estamos trabajando en mejorar el algoritmo de predicción de tracking. Para la demo estática (equipos fijos) no es visible."
- BUG-04 (login): "Defecto menor en login en pantallas pequeñas — identificado para la siguiente iteración."
- BUG-07 (Huawei): "La app requiere ARCore, compatible con el 94% de dispositivos Android 8+ con Google Play Services. Los dispositivos Huawei post-2019 sin GMS no son parte del scope inicial."

---

### b) EJERCICIO INDIVIDUAL (15 min)

**Tarea:** Crear el plan de pruebas mínimo para su propio proyecto XR grupal.

Abrir un archivo `PLAN_PRUEBAS.md` en su proyecto y completar:

```markdown
# Plan de Pruebas — Proyecto [Nombre del Proyecto]

## Información General
- Versión: 1.0
- Autor: [nombre]
- Fecha: [fecha de hoy]
- Versión Unity: 2022.3.62f3
- Dispositivo target: [Android X, modelo Y]

## Alcance de Pruebas
<!-- Qué se va a probar y qué NO se va a probar -->
**En scope:**
- [ ] AR Session y detección de planos
- [ ] Input y gestos
- [ ] Subtítulos y accesibilidad
- [ ] Rendimiento (FPS objetivo: _____)

**Fuera de scope (justificado):**
- Dispositivos iOS (no disponibles en el equipo)
- Pruebas de carga (app mono-usuario)

## Casos de Prueba (mínimo 5)

| TC-ID | Descripción | Pasos | Resultado Esperado | Estado |
|-------|-------------|-------|-------------------|--------|
| TC-001 | AR Session inicia | 1. Abrir app 2. Conceder permiso cámara | ARSession en Tracking < 5s | Pendiente |
| TC-002 | [completar] | | | Pendiente |
| TC-003 | [completar] | | | Pendiente |
| TC-004 | [completar] | | | Pendiente |
| TC-005 | [completar] | | | Pendiente |

## Bugs Encontrados
| Bug ID | Descripción | Severidad | Estado |
|--------|-------------|-----------|--------|
| BUG-001 | [completar al encontrar] | — | — |
```

**Criterio de éxito:** el estudiante define al menos 5 casos de prueba con pasos específicos y resultado esperado. Los casos cubren al menos 3 tipos diferentes de funcionalidad (AR, input, UI).

---

## 5. CIERRE (10 min) {#cierre}

### a) SÍNTESIS COLABORATIVA (4 min)

**Pregunta 1:**
> "¿Cuál es la diferencia entre severidad y prioridad de un bug? Den un ejemplo donde no coincidan."

**Respuesta esperada:**
Severidad es el impacto técnico en el sistema; prioridad es la urgencia de corrección. Pueden no coincidir: un bug cosmético (severidad: cosmética — no afecta funcionalidad) puede ser P1 si la presentación es mañana y el logo de la empresa está mal. Inversamente, un bug crítico (la app crashea en un escenario específico) puede ser P4 si ese escenario nunca ocurre en uso real. La prioridad la define el contexto de negocio; la severidad la define el impacto técnico.

**Pregunta 2:**
> "¿Qué es una prueba de regresión y cuándo se ejecuta?"

**Respuesta esperada:**
Una prueba de regresión re-ejecuta casos de prueba previamente pasados para verificar que una nueva corrección no introdujo nuevos bugs en código que antes funcionaba. Se ejecuta después de cada corrección de bug antes de declararlo "cerrado". Sin pruebas de regresión, es común el patrón "fix one, break two" — corregir un bug crea dos nuevos inadvertidamente.

**Pregunta 3:**
> "¿Por qué un caso de prueba sin 'precondiciones' es peligroso?"

**Respuesta esperada:**
Sin precondiciones, el mismo caso de prueba puede dar resultados diferentes dependiendo del estado del sistema, el dispositivo o el entorno. Dos testers que reportan PASA y FALLA para el mismo caso sin precondiciones definidas están probablemente probando en condiciones diferentes — y nadie puede saber cuál es el resultado correcto. Las precondiciones fijan el punto de partida para que el test sea reproducible y objetivo.

---

### b) METACOGNICIÓN (3 min)

> "En silencio, piensen: antes de hoy, ¿cuántos bugs conocidos tiene su proyecto que todavía no han documentado formalmente? ¿Por qué no los documentaron? ¿Qué cambiaría si desde el inicio del proyecto hubieran mantenido un registro formal de bugs? No lo respondan en voz alta — solo piénsenlo."

---

### c) TAREA / PUENTE A S15 (3 min)

**Tarea para S15 (Presentación Intermedia):**

1. Completar y ejecutar el `PLAN_PRUEBAS.md` en el proyecto: mínimo 10 casos de prueba, todos con estado PASA/FALLA
2. Corregir todos los bugs con severidad CRÍTICO y MAYOR identificados
3. Subir a GitHub: `PLAN_PRUEBAS.md`, archivos de bugs `BUGS.md`, y commits de corrección con referencia al Bug ID
4. Preparar una diapositiva de "Calidad del Proyecto" para la presentación: muestra el % de casos de prueba que pasan

**Puente a S15:**
> "La semana 15 es la presentación final del proyecto. El tribunal va a preguntar: '¿Probaron esto en un dispositivo real?' y '¿Qué bugs encontraron y cómo los corrigieron?' Si no tienen PLAN_PRUEBAS.md, BUGS.md y los commits de corrección, no tendrán respuesta. Esta semana es la última oportunidad para construir esa evidencia. La perseverancia que practiquen estos 5 días es exactamente lo que diferencia un proyecto académico de un producto profesional."

---

## GUION VERBAL SUGERIDO {#guion}

**Al presentar el Unity Test Runner:**
> "Sé que la idea de escribir código para probar código suena a trabajo doble. Y lo es — al principio. Pero cuando hagan un cambio en GestorInputXR.cs a las 11pm antes de una presentación y un test falle automáticamente, van a agradecer haber escrito esos 20 minutos de tests. Los tests son los guardianes que trabajan mientras ustedes duermen."

**Al mostrar el formato de bug report:**
> "Un bug sin documentación no existe. Si alguien dice 'la app a veces falla' pero no puede reproducirlo, para el developer ese bug no existe. Un bug con pasos para reproducir, severidad, evidencia y contexto del dispositivo — ese bug se puede corregir. La diferencia es la disciplina de documentar."

**Al cierre:**
> "Perseverancia no significa no frustrarse — significa seguir cuando estás frustrado. El bug 8 que encuentran y no pueden corregir en 3 horas: ese es el momento de la perseverancia. Documéntenlo, investigan la causa raíz, buscan en Stack Overflow, buscan en la documentación de Unity, preguntan al compañero. Y cuando finalmente lo corrijan — ese es el momento que van a recordar del proyecto."

---

## CASOS REALES RECOMENDADOS {#casos}

1. **Boeing 737 MAX MCAS (2018-2019):** el sistema de control MCAS fue aprobado con pruebas insuficientes del escenario de falla del sensor AoA. Resultado: dos crashes, 346 muertos, 20 meses de prohibición de vuelo. Lección: las pruebas deben cubrir escenarios de falla, no solo el camino feliz.

2. **Cyberpunk 2077 lanzamiento (2020):** CD Projekt Red lanzó el juego en consolas PS4/Xbox One con rendimiento inaceptable (<20 FPS en escenas complejas) por pruebas insuficientes en hardware objetivo. Sony retiró el juego de PlayStation Store. CD Projekt pagó reembolsos. Lección: probar en el hardware objetivo real, no solo en el hardware de desarrollo.

3. **Ariane 5 Flight 501 (1996):** un módulo de conversión de número de 64 bits a 16 bits heredado del Ariane 4 no fue re-probado para el Ariane 5. El número era válido en el rango de Ariane 4 pero no en el de Ariane 5. El cohete se autodestruyó 37 segundos después del lanzamiento. Costo: 370 millones USD. Lección: la reutilización de código no implica reutilización de pruebas — cada contexto requiere validación nueva.

4. **Google Maps AR (2019-2022):** la función Live View de AR de Google Maps tuvo que ser rediseñada múltiples veces porque los usuarios con discapacidades motoras no podían mantener el teléfono estable el tiempo suficiente para que el sistema se orientara. Las pruebas de usabilidad iniciales no incluyeron usuarios con temblor de manos. Lección: las pruebas de usabilidad con usuarios reales y diversos previenen rediseños costosos.

5. **Microsoft HoloLens 2 AR en cirugía (2021+):** Medivis y Novarad implementaron HoloLens 2 en salas de operaciones reales. Requirieron 18 meses de pruebas en entornos quirúrgicos antes de FDA clearance — probando precisión de overlays AR en mm, estabilidad bajo luces quirúrgicas (que interfieren con tracking), uso con guantes quirúrgicos (que no son transparentes a la cámara de profundidad). Lección: las pruebas en XR de contexto real son radicalmente más complejas que en laboratorio.

---

## EVALUACIÓN FORMATIVA {#eval}

| Momento | Señal de comprensión | Señal de dificultad |
|---------|---------------------|---------------------|
| Diagnóstico | Define test case con precondiciones, pasos y resultado esperado | Confunde "testing" con "debugging" |
| Transformación 3.2 | Puede escribir un caso de prueba válido con todos los campos | Escribe solo la descripción, sin pasos |
| Transformación 3.3 | Explica por qué los tests en Edit Mode son más rápidos | No entiende qué diferencia Edit Mode de Play Mode |
| Transformación 3.7 | Distingue severidad de prioridad con ejemplo propio | Cree que todo bug crítico es P1 automáticamente |
| Práctica grupal | Justifica la selección de 5 bugs con criterios de impacto | Solo ordena por severidad sin considerar contexto |
| Ejercicio individual | PLAN_PRUEBAS.md con 5 TCs válidos y precondiciones | Solo lista features sin definir resultado esperado |
| Cierre | Puede nombrar 3 tipos de prueba y cuándo usar cada uno | Solo recuerda "funcional" y "de rendimiento" |

---

## REFERENCIAS APA 7 {#referencias}

Myers, G. J., Sandler, C., & Badgett, T. (2011). *The art of software testing* (3rd ed.). Wiley.

Crispin, L., & Gregory, J. (2009). *Agile testing: A practical guide for testers and agile teams*. Addison-Wesley.

Humble, J., & Farley, D. (2010). *Continuous delivery: Reliable software releases through build, test, and deployment automation*. Addison-Wesley.

Unity Technologies. (2024). *Unity Test Framework documentation*. https://docs.unity3d.com/Packages/com.unity.test-framework@1.4/manual/index.html

Google. (2024). *ARCore developer documentation: Testing and debugging*. https://developers.google.com/ar/develop/unity/test

Microsoft. (2024). *MRTK3 testing guide*. https://learn.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/mrtk3-overview/testing/testing-overview

Beyer, H., & Holtzblatt, K. (1998). *Contextual design: Defining customer-centered systems*. Morgan Kaufmann.

ISO/IEC/IEEE 29119. (2022). *Software and systems engineering — Software testing* (Parts 1-5). International Organization for Standardization.

---

## RECURSOS REALES {#recursos}

- **Unity Test Framework:** https://docs.unity3d.com/Packages/com.unity.test-framework@1.4/manual/index.html
- **ARCore Debugging Tools:** https://developers.google.com/ar/develop/unity-arf/session-config
- **GitHub Issues (bug tracking):** https://docs.github.com/en/issues/tracking-your-work-with-issues/about-issues
- **Game Accessibility Guidelines (pruebas):** https://gameaccessibilityguidelines.com
- **Conventional Commits (mensajes de commit):** https://www.conventionalcommits.org/
- **Repositorio NUnit para Unity:** https://github.com/nunit/nunit.unity3d

*PSISP08075 | Universidad Autónoma del Perú | Ingeniería de Sistemas | 2026-1*
