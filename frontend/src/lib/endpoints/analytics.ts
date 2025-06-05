import { api } from '../api';

export const getSummary = () => api.get('/analytics/summary', {});
export const getForecast = () => api.get('/analytics/forecast', {});
export const getPeriodComparison = () => api.get('/analytics/compare', {});