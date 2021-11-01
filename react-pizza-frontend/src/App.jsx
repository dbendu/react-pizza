import React from 'react';
import { Route } from 'react-router-dom';
import { useDispatch } from 'react-redux';

import { Header } from './components';
import { MainPage, CartPage } from './pages';
import PizzaActions from './redux/reducers/pizzas/actions/'

function App() {
  const dispatch = useDispatch();

  React.useEffect(() => {
    fetch('https://localhost:5001/api/pizzas?page=1&size=50')
      .then((response) => response.json())
      .then((json) => dispatch(PizzaActions.setPizzas(json)));

    fetch('https://localhost:5001/api/pizzas/categories')
      .then((response) => response.json())
      .then((json) => dispatch(PizzaActions.setPizzaCategories(json)));
  }, [dispatch])

  return (
    <div className="wrapper">
      <Header />
      <div className="content">
        <Route path="/" component={MainPage} exact />
        <Route path="/cart" component={CartPage} exact />
      </div>
    </div>
  );
}

export default App