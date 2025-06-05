export type Expense = {
  id: string;
  amount: number;
  description: string;
  date: Date;
  categoryId: string;
  userId: string;
  createdAt: Date;
  updatedAt: Date;
}