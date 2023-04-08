
using Adapter.Classes;

Logger logger = new Logger();
logger.Warn("Warning Message!");
logger.Error("Error message.");
logger.Log("Some information.");

FileWriter writer = new FileWriter("log.txt");

logger = new ConsoleToFileAdapter(writer);
logger.Warn("Warning Message!");
logger.Error("Error message.");
logger.Log("Some information.");
