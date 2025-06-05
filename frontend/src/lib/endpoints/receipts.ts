import { api } from '../api';

export const uploadReceipt = (data: FormData) => api.post('/receipts/upload', data, {});

export const getAllReceipts = () => api.get('/receipts', {});

export const getReceiptsByID = (id: string) => api.get(`/receipts/${id}`, {});
export const deleteReceipt = (id: string) => api.delete(`/receipts/${id}`, {});