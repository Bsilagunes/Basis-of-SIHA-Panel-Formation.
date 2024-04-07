siha panel-1


public class UAVControlPanel {
    // UAV class representing an Unmanned Aerial Vehicle
    public static class UAV {
        private String flightPath;
        private String parkingArea;
        private double speed;
        private double enginePower;
        private double fuelLevel;
        private double altitude;

        // Constructor
        public UAV(String flightPath, String parkingArea, double speed, double enginePower, double fuelLevel, double altitude) {
            this.flightPath = flightPath;
            this.parkingArea = parkingArea;
            this.speed = speed;
            this.enginePower = enginePower;
            this.fuelLevel = fuelLevel;
            this.altitude = altitude;
        }

        // Getters and setters
        public String getFlightPath() { return flightPath; }
        public String getParkingArea() { return parkingArea; }
        public double getSpeed() { return speed; }
        public double getEnginePower() { return enginePower; }
        public double getFuelLevel() { return fuelLevel; }
        public double getAltitude() { return altitude; }

        public void setSpeed(double speed) { this.speed = speed; }
        public void setEnginePower(double enginePower) { this.enginePower = enginePower; }
        public void setFuelLevel(double fuelLevel) { this.fuelLevel = fuelLevel; }
        public void setAltitude(double altitude) { this.altitude = altitude; }

        // Display UAV status
        public void displayStatus() {
            System.out.println("Flight Path: " + flightPath);
            System.out.println("Parking Area: " + parkingArea);
            System.out.println("Speed: " + speed + " m/s");
            System.out.println("Engine Power: " + enginePower + "%");
            System.out.println("Fuel Level: " + fuelLevel + " liters");
            System.out.println("Altitude: " + altitude + " ft");
        }

        // Update flight parameters of the UAV
        public void updateFlightParameters(double speed, double enginePower, double fuelLevel, double altitude) {
            this.speed = speed;
            this.enginePower = enginePower;
            this.fuelLevel = fuelLevel;
            this.altitude = altitude;
        }
    }

    public static void main(String[] args) {
        // Create an instance of UAV
        UAV uav = new UAV("Route 1", "Parking Area A", 25.5, 80.0, 150.0, 500.0);

        // Display initial UAV status
        System.out.println("Initial UAV Status:");
        uav.displayStatus();

        // Update UAV flight parameters
        System.out.println("\nUpdating UAV Flight Parameters...");
        uav.updateFlightParameters(30.0, 85.0, 120.0, 600.0);

        // Display updated UAV status
        System.out.println("\nUpdated UAV Status:");
        uav.displayStatus();
    }
}
