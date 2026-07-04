# Guía de Trabajo 09 — Diseño de Escenarios 3D

## ⚠️ VERSIÓN ESTUDIANTE

**Estudiante:** Oscar Sebastian Santiago Ramirez  **Código:** 2231890767
**Fecha:** 27/06/26 | **Puntuación total:** ____/20

---

## PARTE I — Opción Múltiple (6 puntos)

**1.** ProBuilder en Unity permite:

* [ ] a) Importar modelos de Blender automáticamente
* [x] b) Crear geometría 3D directamente dentro del editor de Unity
* [ ] c) Generar texturas procedurales para cualquier objeto
* [ ] d) Compilar shaders personalizados para AR

**2.** En iluminación "Baked", la iluminación:

* [ ] a) Se calcula en tiempo real en cada frame
* [x] b) Se precalcula y se guarda en texturas (lightmaps) — cero costo en runtime
* [ ] c) Se descarga desde un servidor en la nube
* [ ] d) Solo funciona con luz ambiental, no con luces direccionales

**3.** "Static Batching" en Unity:

* [ ] a) Combina todos los objetos en una sola malla en tiempo real
* [x] b) Agrupa objetos estáticos con el mismo material en un solo draw call
* [ ] c) Reduce el número de polígonos de los objetos automáticamente
* [ ] d) Solo funciona con objetos instanciados desde Prefabs

**4.** LOD Group significa:

* [ ] a) Layer Of Darkness — control de sombras por capa
* [x] b) Level Of Detail — cambia la complejidad del modelo según distancia
* [ ] c) List Of Draw calls — optimización de renderizado
* [ ] d) Load On Demand — carga objetos cuando son necesarios

**5.** Para AR en celular Android de gama media, ¿cuántos draw calls máximo se recomienda?

* [ ] a) ≤500 draw calls
* [ ] b) ≤250 draw calls
* [x] c) ≤100 draw calls
* [ ] d) No hay límite, el driver los gestiona automáticamente

**6.** Occlusion Culling en Unity:

* [ ] a) Reduce la resolución de texturas en tiempo real
* [x] b) Evita renderizar objetos que están ocultos detrás de otros
* [ ] c) Elimina triángulos duplicados de la malla
* [ ] d) Combina materiales similares en uno solo

---

## PARTE II — Completar (6 puntos)

1. El número de **Draw Calls** indica cuántas llamadas de renderizado hace el GPU por frame — debe mantenerse bajo en XR móvil.

2. Para que Static Batching funcione, los objetos deben estar marcados como **Static** en el Inspector de Unity.

3. El proceso de calcular la iluminación y guardarla en texturas se llama hacer **Bake** (o "baking de iluminación").

4. GPU Instancing es útil cuando hay muchos objetos **idénticos** (mismo prefab, mismo material) en la escena.

5. Los **Lightmaps** son texturas que almacenan la **iluminación** precalculada de la escena estática.

6. En ProBuilder, para crear un pasillo o sala a partir de un cubo, se usa la operación de **extrusión** de caras.

---

## PARTE III — Análisis de escena (5 puntos)

Un estudiante reporta estos valores en la ventana **Stats** de Unity:

```text
Draw Calls: 347
Tris: 2.1M
Verts: 1.8M
FPS (Game View): 12
```

**3.1** (2 pt) Identifica los 3 problemas principales de rendimiento basándote en los valores.

| Valor           | Problema                            | Impacto                                                |
| --------------- | ----------------------------------- | ------------------------------------------------------ |
| Draw Calls: 347 | Exceso de draw calls.               | Mayor carga para la CPU y menor rendimiento.           |
| Tris: 2.1M      | Demasiados triángulos en la escena. | La GPU tarda más en renderizar cada frame.             |
| FPS: 12         | Velocidad de renderizado muy baja.  | La aplicación se ejecuta de forma lenta y poco fluida. |

**3.2** (3 pt) Propón 3 técnicas de optimización específicas para mejorar esta escena. Para cada una, indica cómo la aplicarías.

| Técnica           | Cómo aplicarla                                                                                   | Mejora esperada                                          |
| ----------------- | ------------------------------------------------------------------------------------------------ | -------------------------------------------------------- |
| Static Batching   | Marcar los objetos estáticos como **Static** para que Unity los agrupe y reduzca los draw calls. | Disminución de draw calls y mejor rendimiento de la CPU. |
| LOD Group         | Configurar varios niveles de detalle para que los modelos lejanos usen menos polígonos.          | Reducción de triángulos procesados por la GPU.           |
| Occlusion Culling | Activar Occlusion Culling para evitar renderizar objetos ocultos detrás de otros.                | Aumento de FPS al renderizar menos objetos.              |

---

## PARTE IV — Diseño de escenario (3 puntos)

**4.1** (3 pt) Para el escenario de tu proyecto grupal, completa:

| Elemento                                                  | ¿Estático o dinámico? | Técnica de optimización                                                   | Material (descripción)                                                                     |
| --------------------------------------------------------- | --------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------ |
| Piso del entorno (plano detectado por AR)                 | Estático              | Occlusion Culling y Mesh Simplification                                   | Material PBR gris mate con textura de concreto para representar una superficie industrial. |
| Panel holográfico AR                                      | Dinámico              | Canvas World Space y actualización solo cuando cambia el contenido        | Material transparente con emisión (Emission), tonos azul/cian y apariencia holográfica.    |
| Overlays de componentes (flechas, etiquetas y resaltados) | Dinámico              | Activación/Desactivación según el paso del procedimiento (Object Pooling) | Material semitransparente con emisión para destacar componentes de la PC sin ocultarlos.   |
| Modelo 3D de referencia (ej. tarjeta madre o componente)  | Dinámico              | Nivel de detalle (LOD) y mallas optimizadas (Low Poly)                    | Material PBR con texturas metálicas y plásticas para representar fielmente el componente.  |


*PSISP08075 | Universidad Autónoma del Perú | 2026-1*
