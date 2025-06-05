import { api } from '../api';

export const getMyExpenses = () => api.get('/me/expenses', {});
export const getMyReceipts = () => api.get('/me/receipts', {});
export const getMyAnalytics = () => api.get('/me/analytics', {});