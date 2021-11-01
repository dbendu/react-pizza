import { PizzaActions } from "../../actions-constants";

const pizzaCategoriesFilterChangedAction = (activeCategories) => {
  return {
    type: PizzaActions.PizzaCategoriesFilterChanged,
    payload: activeCategories
  }
}

export default pizzaCategoriesFilterChangedAction