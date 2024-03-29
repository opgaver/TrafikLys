const EventEmitter = require("events");

class TrafficLight extends EventEmitter {
  constructor(timing = [5000, 2000, 5000, 2000]) {
    super();
    this.timing = timing;
    this.state = "Yellow";
    this.changeState();
  }

  changeState() {
    this.emit("stateChange", this.state);
    setTimeout(() => {
      switch (this.state) {
        case "Red":
          this.state = "RedYellow";
          this.stateIndex = 1;
          break;
        case "RedYellow":
          this.state = "Green";
          this.stateIndex = 2;
          break;
        case "Green":
          this.state = "Yellow";
          this.stateIndex = 3;
          break;
        case "Yellow":
          this.state = "Red";
          this.stateIndex = 0;
          break;
        default:
          throw new Error("Unknown state");
      }
      this.changeState();
    }, this.timing[this.stateIndex]);
  }

  reset() {
    this.state = "Red";
    this.stateIndex = 0;
    this.changeState();
  }
}

// Simulation
const trafficLight = new TrafficLight();

trafficLight.on("stateChange", (state) => {
  console.log(state);
});

// To keep the Node.js application running and simulate traffic light changes,
// we can use the readline module to wait for user input before exiting.
const readline = require("readline").createInterface({
  input: process.stdin,
  output: process.stdout,
});

readline.question("Press ENTER to stop the traffic light simulation.\n", () => {
  readline.close();
});
