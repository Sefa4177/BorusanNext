import axios, { AxiosResponse } from 'axios';
import { ToDoModel } from '../models/toDoModel';

class ToDoService {
  fetchAll(): Promise<AxiosResponse<ToDoModel[]>> {
    return axios.get<ToDoModel[]>('https://jsonplaceholder.typicode.com/todos');
  }

  // Belirli bir ID'ye göre todo'yu getiren method
  getById(id: number): Promise<AxiosResponse<ToDoModel>> {
    return axios.get<ToDoModel>(`https://jsonplaceholder.typicode.com/todos/${id}`);
  }

  // Belirli bir ID'ye göre todo'yu güncelleyen method
  update(id: number, todo: ToDoModel): Promise<AxiosResponse<ToDoModel>> {
    return axios.put<ToDoModel>(`https://jsonplaceholder.typicode.com/todos/${id}`, todo);
  }
}

export default new ToDoService();
