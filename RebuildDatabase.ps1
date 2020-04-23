Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "jasonsgrocery"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Schemas\Person.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\Stores.Department.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\Stores.Employees.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\Stores.Product.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\Stores.Store.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\Stores.TimeEntry.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\Stores.Transaction.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\Stores.TransactionDetails.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Tables\Stores.WorkPosition.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.AvgEmpSalary.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.DailySales.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.ExpensiveItems.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.HighestPaidEmployees.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.HoursWorked.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.ItemsInDept.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.ItemStockUnderQuantity.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.ItemsUnderCertainPrice.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.ListofEmpInCertainDept.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.ListofPositionsInStore.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.Top10Products.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Procedures\Stores.TransactionExample.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Data\Stores.Employees.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Data\Stores.Produce.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Data\Stores.StoreDepartment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Data\Stores.StoreName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Data\Stores.TimeEntries.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Data\Stores.Transaction.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Data\Stores.TransactionDetails.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "StoreData\Sql\Data\Stores.WorkPosition.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
