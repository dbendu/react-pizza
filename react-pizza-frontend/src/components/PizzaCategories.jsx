import React from "react";

function PizzaCategories({ categories, onActiveCategoriesChanged }) {
  const allCategoriesId = -1;
  const [activeCategoriesIds, setActiveCategoriesIds] = React.useState([]);

  React.useEffect(() => {
    if (activeCategoriesIds !== undefined)
      onActiveCategoriesChanged(activeCategoriesIds);
  }, [activeCategoriesIds]);

  const isAllCategoriesSelected = () => activeCategoriesIds.length === 0;
  const isCategorySelected = (categoryId) => activeCategoriesIds.includes(categoryId);

  const onCategoryButtonClick = (categoryId) => {
    if (categoryId !== allCategoriesId) {
      if (activeCategoriesIds.includes(categoryId))
        setActiveCategoriesIds(activeCategoriesIds.filter(id => id !== categoryId));
      else
        setActiveCategoriesIds(activeCategoriesIds.concat([categoryId]));

      return;
    }

    if (!isAllCategoriesSelected()) {
      setActiveCategoriesIds([]);
    }
  }

  const composeCategoryButton = (categoryName, categoryId, buttonActive) => {
    let className = buttonActive
      ? 'active'
      : '';

    return (
      <li
        onClick={() => onCategoryButtonClick(categoryId)}
        key={categoryName}
        className={className}
      >
        {categoryName}
      </li>
    );
  }

  return (
    <div className='categories'>
      <ul>
        {composeCategoryButton('All', allCategoriesId, isAllCategoriesSelected())}

        {
          categories.map(({ id, value }) => (
            composeCategoryButton(value, id, isCategorySelected(id))
          ))
        }
      </ul>
    </div >
  );
}

export default PizzaCategories;
