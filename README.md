# Spare Parts Inventory Assistant 
This C# console application simulates a chat assistant for managing an inventory of industrial spare parts. The assistant interacts with the user to check the availability of specific parts and responds to special queries about the inventory.

## Features
Inventory Management: Maintains a predefined list of spare parts: hydraulic pump, PLC module, and servo motor.

## User Interaction
- Starts with a greeting: "Hej. Welcome to the spare parts inventory! Which part do you need?"
- Continuously prompts the user for input until a valid part is requested.

## Special Queries
- Handles queries like "Do you actually have any parts?" or "Is there anything in stock at all?" (case-insensitive, tolerant of minor phrasing variations).
- Responds with the number of parts in the inventory and lists each part on a new line: "We have {part_count} part(s)!" followed by the part names.

