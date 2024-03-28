import pandas as pd
import numpy as np
import random
#-Исходная кодировка
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI': lst})
data.head()
# вывод исходной таблицы
print(data)
#-Разделитель между выводимыми таблицами
print('')
#-Перевод в one hot вид
data['tmp'] = 1
data.set_index([data.index, 'whoAmI'], inplace=True)
data = data.unstack(level=-1, fill_value = 0).astype(int)
data.columns = data.columns.droplevel()
data.columns.name = None
# вывод преобразованной таблицы
print(data)
#-------------------------------
