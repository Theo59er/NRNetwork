## Neural Network Farbpräferenz-Detektor für Unity

### Überblick:

Willkommen beim Neural Network Farbpräferenz-Detektor für Unity! Dieses Tool wurde entwickelt, um Ihnen zu helfen, Farbpräferenzen basierend auf vier Farbwerten zu identifizieren: Rot (R), Grün (G), Blau (B) und Alpha (A). Durch die Erstellung und Verwendung von Trainingsdaten kann das neuronale Netzwerk lernen, Farben zu erkennen, die Ihnen eher gefallen oder weniger gefallen.

### Funktionen:

- Verwendet R, G, B und A-Werte zur Analyse von Farbpräferenzen.
- Erfordert die Erstellung von Trainingsdaten zur Verbesserung der Genauigkeit.
- Integration in Unity für eine nahtlose Implementierung.

### Anwendung:

1. **Erstelle Trainingsdaten:**
   - Entwickle einen Satz von Farbdaten, die Präferenzen anzeigen (gemocht/nicht gemocht).
   - Enthält R, G, B und A-Werte für jede Farbe.
   - Speichere die Daten im JSON-Format.

### Trainingsdatenformat:

Die Trainingsdatendatei sollte im JSON-Format vorliegen und wie das folgende Beispiel aussehen:

```json
{
  "Color": {
    "r": 0.5893347859382629,
    "g": 0.16760218143463136,
    "b": 0.3959527611732483,
    "a": 0.6391860246658325
  },
  "Rating": 0.9832248687744141
}
```
### Integration in Unity:
Integrieren Sie das neuronale Netzwerk problemlos in Ihr Unity-Projekt und verwenden Sie es, um Farbpräferenzen dynamisch zu bewerten.

## English:

## Neural Network Color Preference Detector for Unity

### Overview:

Welcome to the Neural Network Color Preference Detector for Unity! This tool is designed to help you identify color preferences based on four color values: Red (R), Green (G), Blue (B), and Alpha (A). By creating and using training data, the neural network can learn to recognize colors that you may prefer or dislike.

### Features:

- Uses R, G, B, and A values to analyze color preferences.
- Requires the creation of training data to enhance accuracy.
- Integration into Unity for seamless implementation.

### Application:

1. **Create Training Data:**
   - Develop a set of color data indicating preferences (liked/disliked).
   - Includes R, G, B, and A values for each color.
   - Save the data in JSON format.

### Training Data Format:

The training data file should be in JSON format and look like the following example:

```json
{
  "Color": {
    "r": 0.5893347859382629,
    "g": 0.16760218143463136,
    "b": 0.3959527611732483,
    "a": 0.6391860246658325
  },
  "Rating": 0.9832248687744141
}
```
### Integration into Unity:
Seamlessly integrate the neural network into your Unity project and use it to dynamically assess color preferences.


### Chinese:

markdown
## Unity神经网络颜色偏好检测器

### 概述：

欢迎使用Unity神经网络颜色偏好检测器！该工具旨在帮助您基于四个颜色值（红色（R），绿色（G），蓝色（B）和Alpha（A））识别颜色偏好。通过创建和使用训练数据，神经网络可以学习识别您可能喜欢或不喜欢的颜色。

### 特点：

- 使用R、G、B和A值分析颜色偏好。
- 需要创建训练数据以提高准确性。
- 无缝集成到Unity中以实现顺畅的实施。

### 应用：

1. **创建训练数据：**
   - 制定一组显示偏好（喜欢/不喜欢）的颜色数据。
   - 为每种颜色包含R、G、B和A值。
   - 以JSON格式保存数据。

### 训练数据格式：

训练数据文件应以JSON格式呈现，并如下示例所示：

```json
{
  "Color": {
    "r": 0.5893347859382629,
    "g": 0.16760218143463136,
    "b": 0.3959527611732483,
    "a": 0.6391860246658325
  },
  "Rating": 0.9832248687744141
}
```
### 集成到Unity中：
将神经网络无缝集成到您的Unity项目中，并使用它动态评估颜色偏好。
