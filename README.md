
# 🌤️ Weathering – A Desktop Weather App

## 🏷️ Badges

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D7?style=for-the-badge&logo=windows&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
[![OpenWeatherMap API](https://img.shields.io/badge/OpenWeatherMap%20API-FF6F00?style=for-the-badge&logo=cloudflare&logoColor=white)](https://openweathermap.org/api)
[![REST API](https://img.shields.io/badge/REST%20API-02569B?style=for-the-badge&logo=api&logoColor=white)](https://restfulapi.net/)
[![JSON](https://img.shields.io/badge/JSON-000000?style=for-the-badge&logo=json&logoColor=white)](https://www.json.org/json-en.html)
[![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)](https://git-scm.com/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)

Weathering is a lightweight and intuitive desktop weather application built using **.NET C# (Windows Forms)**. It connects to an **official Weather API** to fetch **real-time weather conditions** and **forecast updates**, helping users make informed decisions about their day.

---

## 📋 Table of Contents

* [Features](#features)
* [Screenshots](#screenshots)
* [Installation](#installation)
* [How It Works](#how-it-works)
* [Tech Stack](#tech-stack)
* [API Integration](#api-integration)
* [Usage](#usage)
* [Project Structure](#project-structure)
* [Contributing](#contributing)
* [License](#license)
* [Acknowledgments](#acknowledgments)

---

<h2 id="features">🌟 Features</h2>


* 🌍 Fetch **current weather conditions** by city name
* 📆 Get **future weather forecasts** (e.g., 5-day forecast)
* 💡 Displays **temperature, humidity, wind speed, pressure**, and **weather description**
* 📈 Visuals for sunny, cloudy, rainy, and other weather states
* 🖥️ Clean **Windows Forms UI**
* 🔄 Periodic updates with refresh option
* 🚫 Graceful error handling (e.g., city not found, network errors)

---

<h2 id="screenshots">📸 Screenshots</h2>

Comming Soon...

---

<h2 id="installation">💻 Installation</h2>

### Prerequisites

* Windows 10 or higher
* [.NET Framework 4.7.2 or later](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
* Visual Studio 2019 or later (for development)

### Steps

1. Clone the repository:

```bash
git clone https://github.com/shafiamanzoor762/weather_app_.net.git
```

2. Open the solution in Visual Studio:

```bash
cd WeatherApp
WeatherApp.sln
```

3. Install dependencies (NuGet package Newtonsoft.Json is used).

4. Build and run the app (F5 or click ▶️ Run).

---

<h2 id="how-it-works">⚙️ How It Works</h2>

1. User inputs a city name.
2. App sends a request to a public Weather API (OpenWeatherMap).
3. JSON response is parsed and displayed in the UI.
4. Forecast data is stored for quick display and refreshes periodically.

---

<h2 id="tech-stack">🧱 Tech Stack</h2>

* **Language**: C#
* **Framework**: .NET Windows Forms
* **UI**: WinForms Controls
* **API**: [OpenWeatherMap](https://openweathermap.org/api)
* **IDE**: Visual Studio 2022 (recommended)

---

<h2 id="api-integration">🔌 API Integration</h2>

The app uses the OpenWeatherMap API. You need an API key.

### Steps to Obtain API Key:

1. Go to [OpenWeatherMap](https://openweathermap.org/api)
2. Sign up and generate a free API key
3. Update your code to include the API key:

```csharp
string apiKey = "YOUR_API_KEY";
string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
```

---

<h2 id="usage">🚀 Usage</h2>

1. Launch the app.
2. Enter a city name (e.g., **London**, **New York**).
3. Click **"Get Weather"**.
4. View real-time temperature, condition, forecast, and more.

---

<h2 id="project-structure">📁 Project Structure</h2>

```
WeatherAppSourceCode/
├── WeatherApp.sln
├── Weather.cs          # Main Windows Form
├── WeatherInfo.cs      # Deserialization model for Current Weather JSON response
├── WeatherForcast.cs   # Deserialization model for Forcast Weather JSON response
├── Resources/
│   └── weather_icons/    # Weather condition icons
├── App.config            # Optional: API key or settings
└── README.md             # This file
```

---

<h2 id="contributing">🤝 Contributing</h2>

Contributions are welcome!
If you find bugs or want to improve features, follow these steps:

1. Fork the repo
2. Create a feature branch:

   ```bash
   git checkout -b feature/YourFeature
   ```
3. Commit your changes and push:

   ```bash
   git push origin feature/YourFeature
   ```
4. Create a Pull Request

---

<h2 id="license">📄 License</h2>

This project is licensed under the **MIT License**.
See [`LICENSE`](LICENSE) for more details.

---

<h2 id="acknowledgments">📚 Acknowledgments</h2>

* [OpenWeatherMap API](https://openweathermap.org)
* Microsoft .NET Framework
* Stack Overflow Community
* Icons from [Icons8](https://icons8.com/)
