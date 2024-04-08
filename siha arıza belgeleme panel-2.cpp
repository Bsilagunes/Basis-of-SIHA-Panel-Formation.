
#include <iostream>
#include <string>
#include <vector>

using namespace std;

// UAV (Unmanned Aerial Vehicle) class
class UAV {
private:
    string status;
    double enginePower;
    vector<string> malfunctionList;

public:
    // Constructor
    UAV(string status, double enginePower) : status(status), enginePower(enginePower) {}

    // Function to display UAV status
    void displayStatus() {
        cout << "UAV Status: " << status << endl;
        cout << "Engine Power: " << enginePower << "%" << endl;
    }

    // Remote intervention function
    void remoteIntervention(double newEnginePower) {
        cout << "Remote intervention in progress..." << endl;
        enginePower = newEnginePower;
        cout << "New Engine Power: " << enginePower << "%" << endl;
    }

    // Malfunction detection function
    void detectMalfunction() {
        if (enginePower < 50) {
            cout << "Malfunction detected! Engine power is low." << endl;
            malfunctionList.push_back("Low Engine Power");
            cout << "Emergency situation is being reported to the pilot..." << endl;
            // Prepare and report the malfunction documentation to the pilot
            prepareAndReport();
        } else {
            cout << "No malfunction. UAV is operating normally." << endl;
        }
    }

private:
    // Function to prepare and report malfunction documentation (private)
    void prepareAndReport() {
        cout << "Preparing malfunction documentation..." << endl;
        cout << "Malfunction List:" << endl;
        for (const string& malfunction : malfunctionList) {
            cout << "- " << malfunction << endl;
        }
        // Prepare and report the malfunction documentation to the pilot
        cout << "Malfunction documentation has been prepared and reported to the pilot." << endl;
    }
};

int main() {
    // Create UAV
    UAV uav("In Flight", 75.0);

    // Display UAV status
    cout << "Initial UAV Status:" << endl;
    uav.displayStatus();

    // Remote intervention to change engine power
    uav.remoteIntervention(90.0);

    // Detect malfunction
    uav.detectMalfunction();

    return 0;
}
