# Guía de Trabajo 09 — Diseño de Escenarios 3D
## ⚠️ VERSIÓN ESTUDIANTE

**Estudiante:** Borda Garcia, Amie Paola  **Código:** 2231893474
**Fecha:** 18/07/2026 | **Puntuación total:** ____/20

---

## PARTE I — Opción Múltiple (6 puntos)

**1.** ProBuilder en Unity permite:
- [ ] a) Importar modelos de Blender automáticamente
- [x] b) Crear geometría 3D directamente dentro del editor de Unity
- [ ] c) Generar texturas procedurales para cualquier objeto
- [ ] d) Compilar shaders personalizados para AR

**2.** En iluminación "Baked", la iluminación:
- [ ] a) Se calcula en tiempo real en cada frame
- [x] b) Se precalcula y se guarda en texturas (lightmaps) — cero costo en runtime
- [ ] c) Se descarga desde un servidor en la nube
- [ ] d) Solo funciona con luz ambiental, no con luces direccionales

**3.** "Static Batching" en Unity:
- [ ] a) Combina todos los objetos en una sola malla en tiempo real
- [x] b) Agrupa objetos estáticos con el mismo material en un solo draw call
- [ ] c) Reduce el número de polígonos de los objetos automáticamente
- [ ] d) Solo funciona con objetos instanciados desde Prefabs

**4.** LOD Group significa:
- [ ] a) Layer Of Darkness — control de sombras por capa
- [x] b) Level Of Detail — cambia la complejidad del modelo según distancia
- [ ] c) List Of Draw calls — optimización de renderizado
- [ ] d) Load On Demand — carga objetos cuando son necesarios

**5.** Para AR en celular Android de gama media, ¿cuántos draw calls máximo se recomienda?
- [ ] a) ≤500 draw calls
- [x] b) ≤250 draw calls
- [ ] c) ≤100 draw calls
- [ ] d) No hay límite, el driver los gestiona automáticamente

**6.** Occlusion Culling en Unity:
- [ ] a) Reduce la resolución de texturas en tiempo real
- [x] b) Evita renderizar objetos que están ocultos detrás de otros
- [ ] c) Elimina triángulos duplicados de la malla
- [ ] d) Combina materiales similares en uno solo

---

## PARTE II — Completar (6 puntos)

1. El número de Draw Calls  indica cuántas llamadas de renderizado hace el GPU por frame — debe mantenerse bajo en XR móvil.

2. Para que Static Batching funcione, los objetos deben estar marcados como Static en el Inspector de Unity.

3. El proceso de calcular la iluminación y guardarla en texturas se llama hacer Bake (o "baking de iluminación").

4. GPU Instancing es útil cuando hay muchos objetos idénticos (mismo prefab, mismo material) en la escena.

5. Los **Lightmaps** son texturas que almacenan la iluminación precalculada de la escena estática.

6. En ProBuilder, para crear un pasillo o sala a partir de un cubo, se usa la operación de Extrusión de caras.

---

## PARTE III — Análisis de escena (5 puntos)

Un estudiante reporta estos valores en la ventana **Stats** de Unity:

```
Draw Calls: 347
Tris: 2.1M
Verts: 1.8M
FPS (Game View): 12
```

**3.1** (2 pt) Identifica los 3 problemas principales de rendimiento basándote en los valores.

| Valor | Problema | Impacto |
|-------|---------|---------|
| Draw Calls: 347 | Límite excedido para AR móvil| Sobrecarga el CPU|
| Tris: 2.1M |Exceso masivo de polígonos  | Sobrecarga el GPU procesando geometría, causando lentitud extrema en renderizado.|
| FPS: 12 |Tasa de cuadros por segundo inaceptable para XR |Causa latencia severa, mala experiencia de usuario y posible mareo |

**3.2** (3 pt) Propón 3 técnicas de optimización específicas para mejorar esta escena. Para cada una, indica cómo la aplicarías.

| Técnica | Cómo aplicarla | Mejora esperada |
|---------|---------------|----------------|
|Static Batching | Marcar las paredes, suelos y muebles fijos como "Static" asegurándose de que compartan el mismo material.| |
|LOD Groups / Decimación |Crear variantes de baja resolución para los modelos 3D pesados y usar el componente LOD Group según la distancia de la cámara | Reducción significativa de los Tris (Triángulos) y Verts renderizados por frame.|
|Light Baking |Cambiar las luces de "Realtime" a "Baked" en la escena estática y generar Lightmaps desde la ventana de Lighting. | Aumento directo de los FPS al eliminar el cálculo matemático de luces y sombras en tiempo real.|

---

## PARTE IV — Diseño de escenario (3 puntos)

**4.1** (3 pt) Para el escenario de tu proyecto grupal, completa:

| Elemento | ¿Estático o dinámico? | Técnica de optimización | Material (descripción) |
|---------|----------------------|------------------------|----------------------|
|Estructura (Paredes, piso, techo) |Estático |Static Batching y Lightmaps |Material opaco (Mobile/Diffuse), textura comprimida, sin reflejos calculados en tiempo real. |
|Exhibidores / Mesas / Pedestales |Estático |Occlusion Culling y Static Batching |Material plástico o madera horneado (baked), comparte 1 solo atlas de textura. |
|Sillas / Luces decorativas repetidas |Estático |GPU Instancing |Un solo material estándar (Mobile/Unlit) instanciado para todas las copias. |
|Objeto interactivo 3D principal|Dinámico |LOD Group |Material con texturas de mayor calidad, reacciona a luz dinámica horneada (Light Probes). |

*PSISP08075 | Universidad Autónoma del Perú | 2026-1*
