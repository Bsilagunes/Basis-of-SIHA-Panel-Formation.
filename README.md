# Basis-of-SIHA-Panel-Formation.




UAV Control Panel

This project provides a control panel for unmanned aerial vehicles (UAVs). The control panel can be used to monitor, update, and manage the flight parameters of a UAV (Unmanned Aerial Vehicle).

UAV Class:

The UAV class represents the properties and behaviors of an unmanned aerial vehicle. Each instance of a UAV is associated with a specific flight path, parking area, speed, engine power, fuel level, and altitude.

Installation:

To clone the project or download the ZIP file:

bash
Copy code
git clone <repo_url>
Usage:

To compile and run the UAVControlPanel.java file:

bash
Copy code
javac UAVControlPanel.java
java UAVControlPanel
These commands will by default execute the main class of the project and print the initial status of a UAV, followed by its updated status to the console.

Example Usage:

java
Copy code
public class UAVControlPanel {
    public static void main(String[] args) {
        // Create an instance of a UAV
        UAV uav = new UAV("Route 1", "Parking Area A", 25.5, 80.0, 150.0, 500.0);

        // Display the initial UAV status
        System.out.println("Initial UAV Status:");
        uav.displayStatus();

        // Update the UAV flight parameters
        System.out.println("\nUpdating UAV Flight Parameters...");
        uav.updateFlightParameters(30.0, 85.0, 120.0, 600.0);

        // Display the updated UAV status
        System.out.println("\nUpdated UAV Status:");
        uav.displayStatus();
    }
}
Output:

plaintext
Copy code
Initial UAV Status:
Flight Path: Route 1
Parking Area: Parking Area A
Speed: 25.5 m/s
Engine Power: 80.0%
Fuel Level: 150.0 liters
Altitude: 500.0 ft

Updating UAV Flight Parameters...

Updated UAV Status:
Flight Path: Route 1
Parking Area: Parking Area A
Speed: 30.0 m/s
Engine Power: 85.0%
Fuel Level: 120.0 liters
Altitude: 600.0 ft
Contributing:

•	UAV Class: Defines the properties and behaviors of a UAV. It includes attributes such as status (indicating whether the UAV is in flight or not), engine power, and a list to store malfunctions.
•	Constructor: Initializes the UAV object with the given status and engine power.
•	Display Status Function: Displays the current status and engine power of the UAV.
•	Remote Intervention Function: Simulates remote intervention to adjust the engine power of the UAV.
•	Detect Malfunction Function: Checks if there is any malfunction in the UAV, specifically if the engine power is below a certain threshold. If a malfunction is detected, it is added to the malfunction list, and an emergency situation is reported to the pilot.
•	Private Helper Function: prepareAndReport() prepares and reports the malfunction documentation to the pilot.
•	Main Function: Demonstrates the usage of the UAV class by creating a UAV object, displaying its initial status, performing remote intervention to adjust engine power, and detecting malfunctions.
# UAV System Simulation

This C++ program simulates a simplified Unmanned Aerial Vehicle (UAV) system. It provides functionalities to monitor the status of the UAV, perform remote intervention to adjust engine power, and detect malfunctions.

# UAV System Simulation

This C++ program simulates a simplified Unmanned Aerial Vehicle (UAV) system. It provides functionalities to monitor the status of the UAV, perform remote intervention to adjust engine power, and detect malfunctions.

## Features

- **UAV Class**: Defines properties and behaviors of the UAV.
- **Remote Intervention**: Simulates adjusting engine power remotely.
- **Malfunction Detection**: Checks for malfunctions such as low engine power and reports them to the pilot.

## Usage

1. Compile the code using a C++ compiler.
2. Run the compiled executable.
3. Follow the prompts to interact with the UAV system.

## Example

```cpp
#include <iostream>
#include "UAV.h" // Include the UAV header file

int main() {
    // Create UAV object
    UAV uav("In Flight", 75.0);

    // Display initial status
    std::cout << "Initial UAV Status:" << std::endl;
    uav.displayStatus();

    // Perform remote intervention
    uav.remoteIntervention(90.0);

    // Detect malfunctions
    uav.detectMalfunction();

    return 0;
}


If you would like to contribute, please open a pull request to add suggestions or corrections.

License:

This project is licensed under the MIT License. For more information, see the LICENSE file.








