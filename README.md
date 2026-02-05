# 🛒 OHANA Sales & Inventory System

<p align="center">
**A Desktop-based Point of Sale (POS) solution for "OHANA Sweet Delights"**
</p>

---

## 📖 Introduction

The **Cashiering Module** is the core component of the OHANA System. It handles real-time transaction processing, automated inventory updates, and receipt generation. It is built using **VB.NET** with a focus on quick keyboard-driven inputs (Enter-key focus) to ensure a fast checkout process for the cashier.

> [!TIP]
> This module utilizes a **"Dummy Transaction"** approach—items are temporarily staged in a local database table before being finalized, allowing for safe voiding without affecting permanent records prematurely.

---

## 📂 Project Structure

Here is how the project is organized to handle data and reporting:

| Folder/File | Description |
| --- | --- |
| `frmCashiering.vb` | The main logic for sales, voiding, and inventory triggers. |
| `IS_OHD.accdb` | MS Access Database containing Product, Customer, and Sales tables. |
| `GReceipt.rpt` | Crystal Reports template for printing customer receipts. |
| `dummyTrans` | (Table) Temporary storage for items currently in the cart. |

---

## ✨ Key Features

### 1. **Automated Inventory Tracking**

When a transaction is saved, the system automatically subtracts sold quantities from the `Product_Table`.

* **Critical Alerts:** Triggers a `MsgBox` if stock falls below the **Reorder Point (ROP)**.

### 2. **Smart Receipt Generation**

The system uses a custom algorithm to generate incremental Receipt IDs:

```vbnet
' Format: RC + 5 digits (e.g., RC00001)
lastNrno = Val(Mid(lastSrno, 3, 5)) + 1
rno = "RC" & Format(lastNrno, "00000")

```

### 3. **Keyboard-Optimized Workflow**

To speed up sales, the UI is designed for the **Enter** key:

1. Scan/Type **PCode** → Press **Enter** (Fetches price).
2. Type **Qty** → Press **Enter** (Adds to cart).
3. Type **Cash** → Press **Enter** (Calculates change).

---

## 🛠️ Setup & Installation

Follow these steps to set up the development environment:

<Steps>

### Step 1: Database Engine

Install the **Microsoft Access Database Engine 2010 (or later)** to allow the OLEDB provider to connect to the `.accdb` file.

### Step 2: Connection String

Ensure the database file `IS_OHD.accdb` is located in the `/bin/Debug` folder of your project.

### Step 3: Dependencies

Add the following references to your Visual Studio project:

* `ADODB`
* `System.Data.OleDb`
* `CrystalDecisions.CrystalReports.Engine`

</Steps>

---

## 📜 Technical Notes

### Database Connectivity

The project uses a hybrid approach of **ADO.NET (OleDb)** for standard queries and **ADODB Recordsets** for transactional data handling.

```vbnet
' Connection Logic
Public Sub OLEdbconnect(ByVal strQuery As String)
    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= IS_OHD.accdb")
    ' ... execution logic
End Sub

```

