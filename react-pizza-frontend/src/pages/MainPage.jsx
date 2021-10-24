import { Categories, SortPopup, PizzaBlock } from '../components'

function MainPage({ pizzas }) {
  return (
    <div className="container">
      <div className="content__top">
        <Categories
          categoryNames={['Мясные', 'Вегетарианские']}
        />
        <SortPopup sortByParams={['популярности', 'цене']} />
      </div>
      <h2 className="content__title">Все пиццы</h2>
      <div className="content__items">
        {
          pizzas.map((pizza) => <PizzaBlock key={pizza.id} {...pizza} />)
        }
      </div>
    </div>
  );
}

export default MainPage