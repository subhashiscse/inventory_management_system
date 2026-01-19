Product: Id, Name, Price, Quantity, CategoryId, Description
Category: Id, Name
Supplier: Id, Name, Country, ContactInfo
User: Id, Name, Email, Phone, Address
StockTransaction: Id, Quantity, TransactionType: (StockIn, StockOut)


Category 1 - * Product
Supplier 1 - * Product
Product 1 - * StockTransaction

BaseEntity: {
	Id, CreatedAt
}
Product: BaseEntity {
	Name, Price, Quantity, CategoryId, Description
}
Category: BaseEntity {
	Name
}
Supplier: BaseEntity{
	Name, Country, ContactInfo
}
User: BaseEntity{
	Name, Email, Phone, Address
}
StockTransaction: BaseEntity{
	Quantity, TransactionType: StockTransactionType
}
enum StockTransactionType{
	StockIn = 1, StockOut = 2
}
