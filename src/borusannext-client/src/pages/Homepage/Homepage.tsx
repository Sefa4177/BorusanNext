import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import toDoService from "../../services/toDoService";
import { ToDoModel } from "../../models/toDoModel";

const Homepage = () => {
  const [todoList, setTodoList] = useState<ToDoModel[]>([]); // Todo listesi state'i
  const [loaded, setLoaded] = useState(false); // Verinin daha önce yüklenip yüklenmediğini takip eden state

  useEffect(() => {
    // Component yüklendiğinde bir kez çalışacak useEffect
    if (!loaded) {
      fetchTodos(); // Veri daha önce yüklenmemişse verileri getir
      setLoaded(true); // Veri yüklendi olarak işaretlenir
    }
  }, [loaded]);

  // API'den veri getiren fonksiyon
  const fetchTodos = async () => {
    try {
      // LocalStorage'dan veriyi kontrol et
      const cachedTodos = localStorage.getItem('todoList');
      if (cachedTodos) {
        setTodoList(JSON.parse(cachedTodos));
      } else {
        // API üzerinden tüm todoları getirir
        const response = await toDoService.fetchAll();
        const todos = response.data;
        setTodoList(todos);
        // Veriyi LocalStorage'e kaydet
        localStorage.setItem('todoList', JSON.stringify(todos));
      }
    } catch (error) {
      console.error('Veri getirme hatası:', error);
    }
  };

  return (
    <div className="flex items-center justify-center mt-5">
      <div className="grid grid-cols-12">
        {/* todoList dizisindeki her bir todo için kart oluşturulur */}
        {todoList.map(todo => (
          <div className="col-span-3 mb-3 mr-3" key={todo.id}>
            <div className="max-w-sm rounded overflow-hidden shadow-lg">
              <div className="px-6 py-4">
                {/* Todo başlığı */}
                <div className="font-bold text-xl mb-2">{todo.title}</div>
                {/* Todo ID'si */}
                <p className="text-gray-700 text-base">ID: {todo.id}</p>
              </div>
              <div className="px-6 pt-4 pb-2">
                {/* Todo tamamlanma durumu göstergesi */}
                <span className={`inline-block rounded-full px-3 py-1 text-sm font-semibold ${
                  todo.completed ? 'bg-green-200 text-green-700' : 'bg-red-200 text-red-700'
                }`}>
                  {todo.completed ? 'Tamamlandı' : 'Tamamlanmadı'}
                </span>
                {/* Detay sayfasına yönlendirme linki */}
                <Link to={`/details/${todo.id}`}>
                  <button className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded">
                    Detaya Git
                  </button>
                </Link>
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default Homepage;

