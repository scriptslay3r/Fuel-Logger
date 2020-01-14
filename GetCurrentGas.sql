Select startingDiesel, gallonsDieselAdded, gallonsDieselUsed
from FuelLog
where (gallonsDieselAdded IS  NULL)
SELECT SUM(startingDiesel) + SUM(gallonsDieselAdded) - SUM(gallonsDieselUsed)
from FuelLog