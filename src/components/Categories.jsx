import React from "react";

function Categories({categoryNames}) {
  const AllCategoriesButtonId = -1;
  const [activeCategoriesIds, updateActiveCategoriesIds] = React.useState([])

  const onButtonClick = (categoryId) => {
    if (categoryId === AllCategoriesButtonId) {
      updateActiveCategoriesIds([]);
      return;
    }
  
    console.log("called2")
    if (activeCategoriesIds.includes(categoryId))
      updateActiveCategoriesIds(activeCategoriesIds.filter(el => el !== categoryId));
    else
      updateActiveCategoriesIds(activeCategoriesIds.concat([categoryId]));
  }

  const composeCategoryButton = (categoryName, categoryId, buttonActive) => {
    let className = buttonActive
      ? 'active'
      : '';

    return (
      <li
        onClick={() => onButtonClick(categoryId)}
        key = {categoryName}
        className = {className}
      >
        {categoryName}
      </li>
    );
  }

  const isAllCategoriesButtonActive = () => {
    return activeCategoriesIds.length === 0;
  }

  const isCategoryButtonActive = (categoryId) => {
    return activeCategoriesIds.includes(categoryId);
  }

  return (
    <div className='categories'>
      <ul>
        {composeCategoryButton('Все', AllCategoriesButtonId, isAllCategoriesButtonActive())}
        
        {
          categoryNames.map((categoryName, index) => (
            composeCategoryButton(categoryName, index, isCategoryButtonActive(index))
          ))
        }

      </ul>
    </div>
  );
}

export default Categories;