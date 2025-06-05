import { api } from '../api';

export const register = () => api.post('/auth/register', {});
export const login = () => api.post('/auth/login', {});
export const logout = () => api.post('/auth/logout', {});
export const me = () => api.get('/auth/me', {});
export const changePassword = () => api.patch('/auth/password', {});