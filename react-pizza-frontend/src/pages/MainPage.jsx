import { useSelector, useDispatch } from 'react-redux';

import { PizzaCategories, /*SortPopup,*/ PizzaBlock } from '../components'
import pizzaCategoriesFilterChangedAction from '../redux/reducers/pizzas/actions/pizza-categories-filter-changed-action'

function MainPage() {
  const dispatch = useDispatch();
  const {
    pizzaCategories,
    activePizzas
  } = useSelector(({ pizzaCategories, activePizzas }) => ({ pizzaCategories, activePizzas }));

  const onPizzaByCategoriesFilterChanged = (activeCategories) => {
    dispatch(pizzaCategoriesFilterChangedAction(activeCategories))
  }

  return (
    <div className="container">
      <div className="content__top">
        <PizzaCategories
          categories={pizzaCategories}
          onActiveCategoriesChanged={onPizzaByCategoriesFilterChanged}
        />
        {/* <SortPopup sortByParams={['популярности', 'цене']} /> */}
      </div>
      <h2 className="content__title">Все пиццы</h2>
      <div className="content__items">
        {
          activePizzas.map((pizza) => <PizzaBlock key={pizza.id} {...pizza} />)
        }
      </div>
    </div>
  );
}

export default MainPage