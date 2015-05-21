__author__ = 'Veke'


class FileSystem:
	"""docstring for FileSystem"""
	def __init__(self, input_size):
		self.__size = input_size
		self.__available_size = input_size - 1
	def size(self):
		return self.__size
	def available_size(self):
		return self.__available_size
	def get_node(self,path):
		try:
			#something
		except:
			#something
		# TO IMPLEMENT FIND_NODE(PATH)
	def create(self, path, directory=False, content=''):
		# TO IMPLEMENT
	def remove(self, path, directory=False, force=True):
		# TO IMPLEMENT
	def move(self, source, destination):
		# TO IMPLEMENT
	def link(self, source, destination, symbolic=True):
		# TO IMPLEMENT
	def mount(self, file_system, path):
		# TO IMPLEMENT
	def unmount(self, path):
		# TO IMPLEMENT


class Node:
	"""docstring for Node"""
	def __init__(self, is_directory):
		self.__is_directory = is_directory
	def is_directory(self):
		return self.__is_directory

class Directory(Node):
	"""docstring for Directory"""
	def __init__(self):
		super(Directory, self).__init__(True)
		self.arg = arg
		
class File(Node):
	"""docstring for File"""
	def __init__(self, content):
		super(File, self).__init__(False)
		self.__content = content
		



	###
	### Exeptions:
	###

class FileSystemError:

	### All exeptions inherit FileSystemError !

class NodeDoesNotExistError(FileSystemError):

class DestinationNodeDoesNotExistError(NodeDoesNotExistError):

class SourceNodeDoesNotExistError(NodeDoesNotExistError):

	###

class NotEnoughSpaceError(FileSystemError):

class DestinationNodeExistsError(FileSystemError):

class DestinationNotADirectoryError(FileSystemError):

	### remove()

class NonExplicitDirectoryDeletionError(FileSystemError):

class NonEmptyDirectoryDeletionError(FileSystemError):

	### link()

class DirectoryHardLinkError(FileSystemError):

	### mount()

class FileSystemMountError(FileSystemError):

class MountPointNotEmptyError(FileSystemMountError):

class MountPointNotADirectoryError(FileSystemMountError):

class MountPointDoesNotExistError(FileSystemMountError):

	# unmount()

class NotAMountPointError(FileSystemMountError):

	###
	###
	###