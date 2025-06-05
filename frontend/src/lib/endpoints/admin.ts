import { api } from '../api';

export const user = () => api.get('/users', {});
export const getUserID = (id: string) => api.get(`/users/${id}`, {});
export const updateUserInfo = (id: string) => api.post(`/users/${id}`, {});
export const deletUser = (id: string) => api.delete(`/users/${id}`, {});
export const resetUserPassword = (id: string) => api.patch(`/users/${id}/password`, {});
