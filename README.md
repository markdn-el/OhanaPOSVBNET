---

# 🧾 VB.NET Cashiering System

A **Windows Forms–based Cashiering / Point-of-Sale (POS) System** built with **VB.NET**, **Microsoft Access (ACE OLEDB)**, **ADODB**, and **Crystal Reports**.
This application handles product sales, customer lookup, receipt generation, inventory updates, and transaction recording.

---

## 📌 Features

* 🔍 **Product Lookup** via Product Code
* 👤 **Customer Lookup** via Customer ID
* 🛒 **Add / Void Items** in Cart
* 🧮 **Automatic Grand Total & Change Calculation**
* 🧾 **Auto-Generated Receipt Numbers**
* 🖨 **Receipt Printing using Crystal Reports**
* 📦 **Real-Time Inventory Update**
* ⚠ **Critical Stock (Reorder Point) Alerts**
* ❌ **Void Single Item or Entire Transaction**
* 💾 **Transaction & Sales Summary Saving**

---

## 🛠 Technologies Used

* **VB.NET (Windows Forms)**
* **Microsoft Access (.accdb)**
* **OLE DB (Microsoft.ACE.OLEDB.12.0)**
* **ADODB Recordset**
* **Crystal Reports**
* **DataGridView**

---

## 🗂 Database Tables Used

| Table Name       | Purpose                                          |
| ---------------- | ------------------------------------------------ |
| `Product_Table`  | Stores product info, price, stock, reorder point |
| `Customer_Table` | Stores customer details                          |
| `dummyTrans`     | Temporary cart / transaction staging             |
| `MasterTrans`    | Final saved transaction records                  |
| `SalesSummary`   | Transaction summary (total, cash, change)        |

---

## 🔄 Application Flow

1. **Load Form**

   * Connects to database
   * Auto-generates receipt number

2. **Product Search**

   * Enter product code → fetch description & price

3. **Customer Search**

   * Enter customer ID → fetch full customer name

4. **Add Item**

   * Adds item to cart (`dummyTrans`)
   * Updates DataGridView
   * Recomputes grand total

5. **Save Transaction**

   * Validates cash payment
   * Copies data from `dummyTrans` to `MasterTrans`
   * Inserts transaction summary
   * Updates inventory stock
   * Prints receipt
   * Clears cart and resets form

---

## 📄 Receipt System

* Uses **Crystal Reports**
* Displays:

  * Receipt No
  * Customer Name (defaults to *Walk-in Customer*)
  * Item list
  * Total
  * Cash Tendered
  * Change

---

## ⚠ Inventory Logic

* Stock is deducted per item sold
* Triggers a **Critical Stock Alert** if:

  ```
  NewStock <= ReorderPoint
  ```
* Prevents silent inventory depletion

---

## 🚀 Setup Instructions

1. Open project in **Visual Studio**
2. Ensure the following are installed:

   * Microsoft Access Database Engine (ACE)
   * Crystal Reports Runtime
3. Place `IS_OHD.accdb` in the application directory
4. Verify database connection string:

   ```vb
   Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IS_OHD.accdb
   ```
5. Build and run the project

---

## 🧪 Sample Receipt Number Format

```
RC00001
RC00002
RC00003
```

Auto-increments based on the last record in `MasterTrans`.

---

## 📌 Notes & Limitations

* Uses **string-concatenated SQL** (not parameterized)
* Designed for **single-user / local environment**
* Inventory updates assume valid product codes
* Requires Crystal Reports configuration

---

## 📚 Educational Purpose

This project is ideal for:

* Learning **VB.NET database integration**
* Understanding **POS workflows**
* Practicing **inventory management logic**
* Working with **ADODB + Access**

---

## 📜 License

This project is for **educational use**.
Feel free to modify, improve, or extend it.

---

