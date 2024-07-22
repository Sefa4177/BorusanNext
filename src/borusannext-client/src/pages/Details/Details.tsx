import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import toDoService from '../../services/toDoService';
import { ToDoModel } from '../../models/toDoModel';

const Details = () => {
  const { id } = useParams<{ id: string }>();
  const [todo, setTodo] = useState<ToDoModel | null>(null); // Todo objesi için state
  const [isCompleted, setIsCompleted] = useState(false); // Tamamlanma durumu için state
  const [loading, setLoading] = useState(true); // Yüklenme durumu için state
  const [error, setError] = useState<string | null>(null); // Hata durumu için state

  useEffect(() => {
    const fetchTodo = async () => {
      try {
        // API üzerinden todo'yu getirir
        const response = await toDoService.getById(Number(id));
        const fetchedTodo = response.data;

        setTodo(fetchedTodo);
        setIsCompleted(fetchedTodo.completed);
        setLoading(false);
      } catch (error) {
        setError('Todo verilerini getirirken bir hata oluştu.');
        setLoading(false);
      }
    };

    fetchTodo();
  }, [id]);

  const toggleCompleted = async () => {
    if (todo) {
      try {
        // Tamamlanma durumunu güncellemek için API'yi çağır
        const updatedTodo = { ...todo, completed: !isCompleted };
        await toDoService.update(todo.id, updatedTodo);

        // State'i güncelle
        setIsCompleted(!isCompleted);
        setTodo(updatedTodo);
      } catch (error) {
        console.error('Tamamlanma durumu güncellenirken bir hata oluştu:', error);
      }
    }
  };

  if (loading) {
    return <p>Yükleniyor...</p>;
  }

  if (error) {
    return <p>{error}</p>;
  }

  return (
    <div className="flex items-center justify-center mt-5">
      <div className="max-w-md rounded overflow-hidden shadow-lg">
        <div className="px-6 py-4">
          <div className="font-bold text-xl mb-2">{todo?.title}</div>
          <p className="text-gray-700 text-base">ID: {todo?.id}</p>
        </div>
        <div className="px-6 py-4">
          <p className="text-gray-700 text-base">
            Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of "de Finibus Bonorum et Malorum" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance.
          </p>
        </div>
        <div className="px-6 pt-4 pb-2">
          <span className={`inline-block rounded-full px-3 py-1 text-sm font-semibold ${
            isCompleted ? 'bg-green-200 text-green-700' : 'bg-red-200 text-red-700'
          }`}>
            {isCompleted ? 'Tamamlandı' : 'Tamamlanmadı'}
          </span>
          <button
            onClick={toggleCompleted}
            className="ml-3 bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded"
          >
            {isCompleted ? 'Tamamlanmadı Yap' : 'Tamamlandı Yap'}
          </button>
        </div>
      </div>
    </div>
  );
};

export default Details;
